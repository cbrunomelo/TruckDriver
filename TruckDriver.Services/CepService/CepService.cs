using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Services;
using TruckDriver.Services.CepService.JsonDeserializers;

namespace TruckDriver.Services.CepService
{
    public class CepService : ICepService
    {

        public async Task<double> CalcularDistancia(Endereco EnderecoColeta, Endereco EnderecoDestino)
        {
                        

            var geolocalizacaoOrigem = await BuscaGeolocalizacao(EnderecoColeta);
            var geolocalizacaoDestino = await BuscaGeolocalizacao(EnderecoDestino);

            var distancia = CalcularDistanciaPelaGeolocalizacao(geolocalizacaoOrigem, geolocalizacaoDestino);

            
            return Math.Round(distancia, 2);
        }


        public async Task<Endereco> BuscaEnderecoPorCep(string CEP)
        {
            EnderecoJson enderecoJason;
            try
            {
                CEP = CEP.Replace("-", "");

                System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
                HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();

                int cont;
                byte[] buffer = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp;
                Stream stream = resposta.GetResponseStream();
                do
                {
                    cont = stream.Read(buffer, 0, buffer.Length);
                    temp = Encoding.UTF8.GetString(buffer, 0, cont).Trim();
                    sb.Append(temp);

                } while (cont > 0);


                enderecoJason = JsonConvert.DeserializeObject<EnderecoJson>(sb.ToString());
            }
            catch(Exception)
            {

                return null;
            }


            return new Endereco(enderecoJason.cep, enderecoJason.logradouro, enderecoJason.complemento, enderecoJason.bairro, enderecoJason.localidade, enderecoJason.uf);

        }


        private async Task<Geolocalizacao> BuscaGeolocalizacao(Endereco endereco)
        {
            
            string uriParametros = ContruirUriComParametro(endereco);
            string apiUrl = $"https://nominatim.openstreetmap.org/search?{uriParametros}&format=geojson";
            string responseBody = string.Empty;
            GeolocationJson geolocationJson = null;

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("User-Agent", "MinhaApp/1.0"); 
                try
                {
                    HttpResponseMessage response = httpClient.GetAsync(apiUrl).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        responseBody = await response.Content.ReadAsStringAsync();
                        geolocationJson = JsonConvert.DeserializeObject<GeolocationJson>(responseBody);

                    }

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Erro na requisição HTTP: {e.Message}");
                }
            }

            

            if (geolocationJson.features.Count > 0)
            {               
                return new Geolocalizacao() { Longitude = (float)geolocationJson.features[0].geometry.coordinates[0], Latitude = (float)geolocationJson.features[0].geometry.coordinates[1] };
            }

            return null;
        }

        private double CalcularDistanciaPelaGeolocalizacao(Geolocalizacao geo1, Geolocalizacao geo2)
        {

            var radius = 6371; // Raio da Terra em quilômetros

            var dLat = ParaRadianos(geo2.Latitude - geo1.Latitude);
            var dLon = ParaRadianos(geo2.Longitude - geo1.Longitude);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ParaRadianos(geo1.Latitude)) * Math.Cos(ParaRadianos(geo2.Latitude)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            var distance = radius * c; // Distância em quilômetros

            return distance;
        }

        private static double ParaRadianos(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private string ContruirUriComParametro(Endereco endereco)
        {
            string uri = "street=" + endereco.Logradouro.Replace(" ", "+") + "&city=" + endereco.Cidade.Replace(" ", "+") + "&county=Brasil&state=" + endereco.Estado.Replace(" ", "+");
            return uri;
        }


    }
}
