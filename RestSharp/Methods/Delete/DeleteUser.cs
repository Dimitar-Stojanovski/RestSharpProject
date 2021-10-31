using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace RestSharpProject.Methods.Delete
{
    public class DeleteUser
    {
        private APICalls apiCalls;
        private APIRequests apiRequests;

        public DeleteUser()
        {
            apiCalls = new APICalls();
            apiRequests = new APIRequests();
        }

        public IRestResponse DeleteUserSuccesfully(string _endpoint)
        {
            var client = apiCalls.SetUrl(_endpoint);
            var request = apiRequests.CreateDeleteMethod();
            request.RequestFormat = DataFormat.Json;
            var response = apiCalls.GetResponse(client, request);
            return response;

        }
    }
}
