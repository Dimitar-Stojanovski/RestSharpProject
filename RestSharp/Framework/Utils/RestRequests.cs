﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpProject
{
   public class RestRequests
    {
        private RestRequest restRequest;

        public RestRequest CreateGetMethod()
        {
            restRequest = new RestRequest() {Method = Method.Get };
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public RestRequest CreatePostRequest<T>(T _payload) where T:class
        {
            restRequest = new RestRequest() {Method = Method.Post };
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddBody(_payload);
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }
        public RestRequest CreatePutRequest<T>(T _payload) where T:class
        {
            restRequest = new RestRequest() { Method = Method.Put};
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddBody(_payload);
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }
        public RestRequest CreatePatchRequest<T>(T _payload) where T:class
        {
            restRequest = new RestRequest() { Method = Method.Patch };
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddBody(_payload);
            restRequest.RequestFormat = DataFormat.Json;
            return restRequest;
        }

        public RestRequest CreateDeleteMethod()
        {
            restRequest = new RestRequest() { Method = Method.Delete };
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }
    }
}
