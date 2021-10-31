using NUnit.Framework;
using RestSharpProject.Methods.Get;
using RestSharpProject.Pages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RestSharpProject.Tests
{
    public class GetSingleUserTest
    {
        public HttpStatusCode statusCode;

        [Test]
        public void GetSingleUser()
        {
            var api = new GetSingleUsers();
            var response = api.GetSingleUser("api/users/2");
            Console.WriteLine(response.StatusCode);
            var user = ModifyContent.DeserializeJson<SingleUserPage>(response);
            Assert.AreEqual(2, user.data.id);
            Assert.AreEqual("janet.weaver@reqres.in", user.data.email);
        }

        [Test]
        public void GetSingleUserNotFound()
        {
            var api = new GetSingleUsers();
            var response = api.GetSingleUser("api/users/23");
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(404, code);
        }
    }
}
