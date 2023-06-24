using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace TruckDriver.WindowsFormsApp.Services
{
    internal class CepAutocomplete
    {
        public static Dictionary<string, string> BuscaCep(string CEP)
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


            CepJason cep = JsonConvert.DeserializeObject<CepJason>(sb.ToString());


            Dictionary<string, string> endereco = new Dictionary<string, string>()
            {
                { "logradouro", cep.logradouro },
                {"bairro", cep.bairro },
                { "cidade", cep.localidade },
                { "estado" , cep.uf}

        };



            return endereco;

        }


        private class CepJason
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
        }

    }
}
