using RestSharp;
using System;

namespace simp_ws_lei.MVC.Views
{
    public class RestSharpCaller : IApiCaller
    {
        private readonly RestClient client;
        private readonly RestRequest request;
        private RestResponse response;

        public RestSharpCaller()
        {
            this.client = new RestClient();
            this.request = new RestRequest();
            this.response = new RestResponse();
        }

        public string Get(string url)
        {
            //Sem Conexão à Rede
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                throw new Exception("Connection Error!");
            }

            this.request.Resource = url;
            this.request.Method = RestSharp.Method.Get;
            this.response = this.client.Execute(this.request);

            //Falha acesso á fonte
            if (this.response.ErrorException != null)
            {
                throw this.response.ErrorException;
            }

            //Dados null WService
            if (this.response.Content == null)
            {
                throw new ArgumentNullException("Response content is null!");
            }

            return this.response.Content;
        }
    }
}
