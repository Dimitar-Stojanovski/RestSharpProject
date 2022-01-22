using NUnit.Framework;
using RestSharpProject.Framework.Utils;
using RestSharpProject.Pages.PostPages;
using System.Net;
using System.Threading.Tasks;

namespace RestSharpProject.Tests
{
    public class RegisterSuccessfullTests
    {
        private HttpStatusCode statusCode;

        [Test]
        public async Task RegisterUser()
        {
            var _registeredUser = new RegisterSuccesfullRequestPage
            {
                email = "eve.holt@reqres.in",
                password = "pistol"
            };

            var api = new RestResponses();
            var response = await api.CreatePostResponse("api/register", _registeredUser);
            statusCode = response.StatusCode;
            var code = (int)statusCode;
            Assert.AreEqual(code, 200);
            var _content = ModifyContent.DeserializeJson<RegisterSuccessfullResponsePage>(response);
            Assert.AreEqual(_content.id, 4);
            Assert.AreEqual(_content.token, "QpwL5tke4Pnpja7X4");
        }
    }
}
