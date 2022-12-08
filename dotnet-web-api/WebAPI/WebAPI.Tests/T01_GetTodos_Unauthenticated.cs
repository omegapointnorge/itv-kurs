using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Tests.Config;

namespace WebAPI.Tests
{
    [TestClass]
    public class T01_GetTodos_Unauthenticated : WebApiTestBase
    {
        [TestMethod]
        public async Task Unauthenticated_Users_Should_Not_Get_Todos()
        {
            var response = await Client.GetAsync("api/Todos");
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }
    }
}