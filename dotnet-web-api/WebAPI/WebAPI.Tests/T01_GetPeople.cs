using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebAPI.Tests
{
    [TestClass]
    public class T01_GetPeople : WebApiTestBase
    {
        [TestMethod]
        public async Task HelloWorldTest()
        {
            var client = BuildClient();

            var response = await client.GetAsync("WeatherForecast");
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
    }
}