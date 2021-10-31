using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpProject.Methods.Get
{
    public class GetSingleUsers
    {
        private APICalls apiCalls;
        private APIRequests apiRequests;

        public GetSingleUsers()
        {
            apiCalls = new APICalls();
            apiRequests = new APIRequests();
        }

        public IRestResponse GetSingleUser(string _payload)
        {
            var client = apiCalls.SetUrl(_payload);
            var request = apiRequests.CreateGetMethod();
            request.RequestFormat = DataFormat.Json;
            var response = apiCalls.GetResponse(client, request);
            return response;
        }
    }
}
