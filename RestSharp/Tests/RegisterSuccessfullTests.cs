using NUnit.Framework;
using RestSharpProject.Pages.PostPages;
using System;
using System.Collections.Generic;
using System.Net;
using RestSharpProject.Pages;
using RestSharpProject.Methods.Post;

namespace RestSharpProject.Tests
{
    public class RegisterSuccessfullTests
    {
        private HttpStatusCode statusCode;

        [Test]
        public void RegisterUser()
        {
            var _registeredUser = new RegisterSuccesfullRequestPage
            {
                email = "eve.holt@reqres.in",
                password = "pistol"
            };

            var api = new RegisterSuccesfull();
            var response = api.RegisterUserSuccessfully("api/register", _registeredUser);
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(code, 200);
            var _content = ModifyContent.DeserializeJson<RegisterSuccessfullResponsePage>(response);
            Assert.AreEqual(_content.id, 4);
            Assert.AreEqual(_content.token, "QpwL5tke4Pnpja7X4");
        }
    }
}
