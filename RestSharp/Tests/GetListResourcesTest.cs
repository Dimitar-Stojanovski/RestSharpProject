using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using NUnit.Framework;
using RestSharpProject.Methods.Get;
using RestSharpProject.Pages;

namespace RestSharpProject.Tests
{
    public class GetListResourcesTest
    {
        private HttpStatusCode statusCode;

        [Test]
        public void GetListTest()
        {
            var api = new GetListResources();
            var response = api.GetListofResources("api/unknown");
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Console.WriteLine(code);
            Assert.AreEqual(200, code);
            var resources = ModifyContent.DeserializeJson<ListResourcePage>(response);
            Assert.AreEqual("cerulean", resources.data[0].name);
        }
    }
}
