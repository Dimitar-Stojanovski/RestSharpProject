using NUnit.Framework;
using RestSharpProject.Methods.Post;
using RestSharpProject.Pages.PostPages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RestSharpProject.Tests
{
   public class CreateUserTest
    {
        private HttpStatusCode statusCode;

        [Test]
        public void CreateUserSample()
        {
            var _createUser = new CreateUserRequestPage
            {
                name = "John",
                job = "QA Tester"
            };

            var api = new CreateUserRequest();
            var resposne = api.CreateUserForRequresIn("api/users", _createUser);
            statusCode = resposne.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(201, code);
            var content = ModifyContent.DeserializeJson<CreateUserResponsePage>(resposne);
            Assert.AreEqual(content.name, "John");
            Assert.AreEqual(content.job, "QA Tester");
           
            
            
        }
    }
}
