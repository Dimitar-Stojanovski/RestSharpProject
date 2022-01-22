using NUnit.Framework;
using RestSharpProject.Framework.Utils;
using RestSharpProject.Methods.Post;
using RestSharpProject.Pages.PostPages;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpProject.Tests
{
   public class CreateUserTest
    {
        private HttpStatusCode statusCode;

        [Test]
        public async Task CreateUserSample()
        {
            var _createUser = new CreateUserRequestPage
            {
                name = "John",
                job = "QA Tester"
            };

            var api = new RestResponses();
            var response = await api.CreatePostResponse("api/users", _createUser);
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(201, code);
            var content = ModifyContent.DeserializeJson<CreateUserResponsePage>(response);
            Assert.AreEqual(content.name, "John");
            Assert.AreEqual(content.job, "QA Tester");
           
            
            
        }
    }
}
