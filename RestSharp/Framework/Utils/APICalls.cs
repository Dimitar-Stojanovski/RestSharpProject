﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RestSharpProject
{
    public class APICalls
    {
        private RestClient restClient;
        private const string _URL = "https://reqres.in/";

        public RestClient SetUrl(string _endpoint)
        {
            var url = Path.Combine(_URL, _endpoint);
            restClient = new RestClient(url);
            return restClient;
        }

        public IRestResponse GetResponse(RestClient restClient, RestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }
    }
}
