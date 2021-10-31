using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using NUnit.Framework;
using RestSharpProject.Methods.Delete;

namespace RestSharpProject.Tests
{
   public class DeleteUserTests
    {
        private HttpStatusCode statusCode;

        [Test]
        public void DeleteUser()
        {
            var api = new DeleteUser();
            var response = api.DeleteUserSuccesfully("api/users/2");
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(code, 204);
            Assert.AreEqual("No Content", response.StatusCode);


        }
    }
}
