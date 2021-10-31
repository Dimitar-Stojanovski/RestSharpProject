using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace RestSharpProject.Methods.Post
{
    public class RegisterSuccesfull
    {
        private APICalls apiCalls;
        private APIRequests apiRequests;

        public RegisterSuccesfull()
        {
            apiCalls = new APICalls();
            apiRequests = new APIRequests();
        }

        public IRestResponse RegisterUserSuccessfully(string _endpoint, dynamic _payload)
        {
            var client = apiCalls.SetUrl(_endpoint);
            var jsonString = ModifyContent.SerializeJson(_payload);
            var request = apiRequests.CreatePostRequest(jsonString);
            var resposne = apiCalls.GetResponse(client, request);
            return resposne;
        }


    }
}
