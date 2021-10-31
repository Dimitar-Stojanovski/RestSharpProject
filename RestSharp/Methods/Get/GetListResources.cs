using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace RestSharpProject.Methods.Get
{
    public class GetListResources
    {
        private APICalls apiCalls;
        private APIRequests apiRequests;

        public GetListResources()
        {
            apiCalls = new APICalls();
            apiRequests = new APIRequests();
        }

        public IRestResponse GetListofResources(string _payload)
        {
            var client = apiCalls.SetUrl(_payload);
            var request = apiRequests.CreateGetMethod();
            request.RequestFormat =DataFormat.Json;
            var response = apiCalls.GetResponse(client, request);
            return response;
        }
    }
}
