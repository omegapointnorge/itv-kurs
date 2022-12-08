using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Tests.Config;
using System.Linq;

namespace WebAPI.Tests
{
    [TestClass]
    public class T04_Post_Todo : AuthorizedUserTestBase
    {
        [TestMethod]
        public async Task Should_Correctly_Post()
        {
            var content = RequestBody(new Todo.Todo { Name = "TestId" });
            var response = await Client.PostAsync("api/Todos", content);
            response.StatusCode.Should().Be(HttpStatusCode.Created);
            var todo = await ResponseBody<Todo.Todo>(response);

            var allTodosResponse = await Client.GetAsync("api/Todos");
            var allTodos = await ResponseBody<List<Todo.Todo>>(allTodosResponse);

            allTodos.Count(x => x.Id == todo.Id).Should().Be(1);
            response.Headers.Location!.ToString().Should().EndWith($"api/Todos/{todo.Id}");
        }
    }
}