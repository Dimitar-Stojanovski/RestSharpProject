using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace RestSharpProject.Methods.Put
{
    public class UpdateUser
    {
        private APICalls apiCalls;
        private APIRequests apiRequests;

        public UpdateUser()
        {
            apiCalls = new APICalls();
            apiRequests = new APIRequests();
        }

        public IRestResponse UpdateRegisteredUser(string _endpoint, dynamic _payload)
        {
            var client = apiCalls.SetUrl(_endpoint);
            var jsonString = ModifyContent.SerializeJson(_payload);
            var request = apiRequests.CreatePutRequest(jsonString);
            var response = apiCalls.GetResponse(client, request);
            return response;

        }


    }
}
