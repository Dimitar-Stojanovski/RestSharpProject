using NUnit.Framework;
using RestSharpProject.Framework.Utils;
using RestSharpProject.Pages;
using System;
using System.Net;
using System.Threading.Tasks;

namespace RestSharpProject.Tests
{
    public class GetSingleUserTest
    {
        public HttpStatusCode statusCode;

        [Test]
        public async Task GetSingleUser()
        {
            var api = new RestResponses();
            var response = await api.CreateGetResponse("api/users/2");
            Console.WriteLine(response.StatusCode);
            var user = ModifyContent.DeserializeJson<SingleUserPage>(response);
            Assert.AreEqual(2, user.data.id);
            Assert.AreEqual("janet.weaver@reqres.in", user.data.email);
        }

        [Test]
        public async Task GetSingleUserNotFound()
        {
            var api = new RestResponses();
            var response = await api.CreateGetResponse("api/users/23");
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(404, code);
        }
    }
}
