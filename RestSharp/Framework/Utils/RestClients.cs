using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpProject
{
    public class RestClients
    {
        private RestClient restClient;
        private const string _URL = "https://reqres.in/";

        public RestClient SetUrl(string _endpoint)
        {
            var url = Path.Combine(_URL, _endpoint);
            restClient = new RestClient(url);
            return restClient;
        }

        public async Task <RestResponse> GetResponseAsync(RestClient restClient, RestRequest restRequest)
        {
            return await restClient.ExecuteAsync(restRequest);
        }
    }
}
