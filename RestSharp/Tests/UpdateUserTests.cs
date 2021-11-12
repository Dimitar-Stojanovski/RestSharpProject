using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using NUnit.Framework;
using RestSharpProject.Pages;
using RestSharpProject.Methods.Put;
using RestSharpProject.Framework.DataProviders;

namespace RestSharpProject.Tests
{
   public class UpdateUserTests
    {
        private HttpStatusCode statusCode;

        [Test]
        public void UpdateUserSuccessfully()
        {
            Assert.Multiple(() =>
            {
                var _updatedUser = new UpdateUserRequestPage
                {
                    name = "John",
                    job = "President"
                };

                var api = new UpdateUser();
                var response = api.UpdateRegisteredUser("api/users/2", _updatedUser);
                statusCode = response.StatusCode;
                var code = (int)statusCode;
                Assert.AreEqual(code, 200);
                var _content = ModifyContent.DeserializeJson<UpdateUserResponsePage>(response);
                Assert.AreEqual(_content.name, "John");
                Assert.AreEqual(_content.job, "President");
            });
           

        }


        [TestCaseSource(typeof(DataForPatch), nameof(DataForPatch.TestDataForPatch))]
        public void PatchUserSuccesfully(string _name, string _job)
        {
            Assert.Multiple(() =>
            {
                var _patchUser = new UpdateUserRequestPage
                {
                    name = _name,
                    job = _job,
                };

                var api = new UpdateUser();
                var response = api.UpdateRegisteredUserWithPatch("api/users/2", _patchUser);
                statusCode = response.StatusCode;
                Console.WriteLine(statusCode);
                Assert.AreEqual((int)statusCode, 200);
                var content = ModifyContent.DeserializeJson<UpdateUserResponsePage>(response);
                Assert.AreEqual(content.name, _name);
                Assert.AreEqual(content.job, _job);

            });
        }


    }
}
