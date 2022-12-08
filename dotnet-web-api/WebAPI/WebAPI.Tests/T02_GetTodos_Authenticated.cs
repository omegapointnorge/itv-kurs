using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Tests.Config;

namespace WebAPI.Tests
{
    [TestClass]
    public class T02_GetTodos_Authenticated : WebApiTestBase
    {
        public override void Given()
        {
            AuthenticateUser();
        }

        [TestMethod]
        public async Task Authorized_Users_Should_Not_Get_Todos()
        {
            var response = await Client.GetAsync("api/Todos");
            response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        }
    }
}