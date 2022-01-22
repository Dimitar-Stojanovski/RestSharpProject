using System;
using System.Net;
using System.Threading.Tasks;
using NUnit.Framework;
using RestSharpProject.Framework.Utils;
using RestSharpProject.Pages;

namespace RestSharpProject.Tests
{
    public class GetListResourcesTest
    {
        private HttpStatusCode statusCode;

        [Test]
        public async Task GetListTest()
        {
            var api = new RestResponses();
            var response = await api.CreateGetResponse("api/unknown");
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Console.WriteLine(code);
            Assert.AreEqual(200, code);
            var resources = ModifyContent.DeserializeJson<ListResourcePage>(response);
            Assert.AreEqual("cerulean", resources.data[0].name);
        }
    }
}
