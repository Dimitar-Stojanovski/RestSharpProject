using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpProject.Methods.Post
{
   public class CreateUserRequest
    {
        private APICalls apiCalls;
        private APIRequests apiRequests;

        public CreateUserRequest()
        {
            apiCalls = new APICalls();
            apiRequests = new APIRequests();
        }

        public IRestResponse CreateUserForRequresIn(string _endpoint, dynamic _payload)
        {
            var client = apiCalls.SetUrl(_endpoint);
            var jsonString = ModifyContent.SerializeJson(_payload);
            var request = apiRequests.CreatePostRequest(jsonString);
            var response = apiCalls.GetResponse(client, request);
            return response;

        }
    }
}
