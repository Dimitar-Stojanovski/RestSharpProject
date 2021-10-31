﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RestSharpProject
{
    public static class ModifyContent
    {
        public static T DeserializeJson<T>(IRestResponse response)
        {
            var content = response.Content;
            return JsonSerializer.Deserialize<T>(content);
        }

        public static string SerializeJson(dynamic _content)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(_content, options);
        }
    }
}
