using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using NUnit.Framework;
using RestSharpProject.Pages;
using RestSharpProject.Methods.Put;
using System.Threading.Tasks;
using RestSharpProject.Framework.Utils;

namespace RestSharpProject.Tests
{
   public class UpdateUserTests
    {
        private HttpStatusCode statusCode;

        [Test]
        public async Task UpdateUserSuccessfully()
        {
            Assert.Multiple(async() =>
            {
                var _updatedUser = new UpdateUserRequestPage
                {
                    name = "John",
                    job = "President"
                };

                var api = new RestResponses();
                var response = await api.CreatePutResponse("api/users/2", _updatedUser);
                statusCode = response.StatusCode;
                var code = (int)statusCode;
                Assert.AreEqual(code, 200);
                var _content = ModifyContent.DeserializeJson<UpdateUserResponsePage>(response);
                Assert.AreEqual(_content.name, "John");
                Assert.AreEqual(_content.job, "President");
            });
           

        }


    }
}
