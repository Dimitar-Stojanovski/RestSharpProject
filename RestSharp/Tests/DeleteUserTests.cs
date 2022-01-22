using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using NUnit.Framework;
using System.Threading.Tasks;
using RestSharpProject.Framework.Utils;

namespace RestSharpProject.Tests
{
   public class DeleteUserTests
    {
        private HttpStatusCode statusCode;

        [Test]
        public async Task DeleteUser()
        {
            var api = new RestResponses();
            var response = await api.CreateDeleteResponse("api/users/2");
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(code, 204);
            Assert.AreEqual("No Content", response.StatusCode);


        }
    }
}
