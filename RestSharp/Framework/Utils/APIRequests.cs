using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpProject
{
   public class APIRequests
    {
        private RestRequest restRequest;

        public RestRequest CreateGetMethod()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public RestRequest CreatePostRequest(string _payload)
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", _payload, ParameterType.RequestBody);
            return restRequest;
        }
        public RestRequest CreatePutRequest(string _payload)
        {
            restRequest = new RestRequest(Method.PUT);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", _payload, ParameterType.RequestBody);
            return restRequest;
        }
        public RestRequest CreatePatchRequest(string _payload)
        {
            restRequest = new RestRequest(Method.PATCH);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", _payload, ParameterType.RequestBody);
            return restRequest;
        }

        public RestRequest CreateDeleteMethod()
        {
            restRequest = new RestRequest(Method.DELETE);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
    }
}
