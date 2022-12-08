using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Tests;

public class WebApiTestBase
{
    private bool UserIsAuthenticated { get; set; }

    protected HttpClient BuildClient()
    {
        var client = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    if (UserIsAuthenticated)
                    {
                        services.AddAuthentication("Test")
                            .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                                "Test", options => { });
                    }
                });
            })
            .CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false,
            });

        if (UserIsAuthenticated)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Test");

        }

        return client;
    }

    protected void AuthenticateUser()
    {
        UserIsAuthenticated = true;
    }
}