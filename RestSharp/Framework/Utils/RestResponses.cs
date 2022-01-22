using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpProject.Framework.Utils
{
    public class RestResponses
    {
        private RestClients restClients;
        private RestRequests restRequests;

        public RestResponses()
        {
            restClients = new RestClients();
            restRequests = new RestRequests();
        }


        public async Task<RestResponse> CreateGetResponse(string _payload)
        {
            var client = restClients.SetUrl(_payload);
            var request = restRequests.CreateGetMethod();
            request.RequestFormat = DataFormat.Json;
            var response = await restClients.GetResponseAsync(client, request);
            return response;
        }

        public async Task <RestResponse> CreatePostResponse(string _endpoint, dynamic _payload)
        {
            var client = restClients.SetUrl(_endpoint);
            var request = restRequests.CreatePostRequest(_payload);
            var response = await restClients.GetResponseAsync(client, request);
            return response;

        }

        public async Task <RestResponse> CreatePutResponse(string _endpoint, dynamic _payload)
        {
            var client = restClients.SetUrl(_endpoint);
            var request = restRequests.CreatePutRequest(_payload);
            var response = await restClients.GetResponseAsync(client, request);
            return response;

        }

        public async Task <RestResponse> CreateDeleteResponse(string _endpoint)
        {
            var client = restClients.SetUrl(_endpoint);
            var request = restRequests.CreateDeleteMethod();
            request.RequestFormat = DataFormat.Json;
            var response = await restClients.GetResponseAsync(client, request);
            return response;

        }
    }
}
