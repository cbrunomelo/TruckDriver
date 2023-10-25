using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
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

        public float CalcularDistancia(string cepOrigem, string cepDestino)
        {
            
            //retornar o endereco dos ceps


            
            return 200;
        }


        public async Task<Endereco> BuscaCep(string CEP)
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


            EnderecoJson enderecoJason = JsonConvert.DeserializeObject<EnderecoJson>(sb.ToString());


            return new Endereco(enderecoJason.cep, enderecoJason.logradouro, enderecoJason.complemento, enderecoJason.bairro, enderecoJason.localidade, enderecoJason.uf);

        }


        private Geolocalizacao BuscaGeolocalizacao(Endereco endereco)
        {            
            string uriParametros = ContruirUriComParametro(endereco);
            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create($"https://nominatim.openstreetmap.org/search?{uriParametros}&format=geojson");
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


            GeolocationJson geolocationJson = JsonConvert.DeserializeObject<GeolocationJson>(sb.ToString());

            if (geolocationJson.features.Count > 0)
            {               
                return new Geolocalizacao() { Longitude = (float)geolocationJson.features[0].geometry.coordinates[0], Latitude = (float)geolocationJson.features[0].geometry.coordinates[1] };
            }

            return null;
        }

        private float CalcularDistancia(Geolocalizacao geo1, Geolocalizacao geo2)
        {

            return 0;
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
