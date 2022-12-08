using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Tests.Config;

namespace WebAPI.Tests
{
    [TestClass]
    public class T03_GetTodos_Authorized : AuthorizedUserTestBase
    {
        [TestMethod]
        public async Task Authorized_Users_Should_Get_Todos()
        {
            var response = await Client.GetAsync("api/Todos");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}