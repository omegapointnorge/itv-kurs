using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using WebAPI.Tests.Auth;

namespace WebAPI.Tests.Config;

public abstract class WebApiTestBase
{
    private bool UserIsAuthenticated { get; set; }
    private bool UserIsAuthorized { get; set; }

    protected HttpClient Client { get; private set; }

    [TestInitialize]
    public void Setup()
    {
        Given();
        Client = BuildClient();
    }

    public virtual void Given()
    {
    }

    private HttpClient BuildClient()
    {
        var client = new WebApplicationFactory<Program>()
            .WithWebHostBuilder(HandleAuth)
            .CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false,
            });

        if (UserIsAuthenticated)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Authenticated");
        }

        return client;
    }

    protected StringContent RequestBody<T>(T requestBody)
    {
        return new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
    }

    protected async Task<T> ResponseBody<T>(HttpResponseMessage httpResponseMessage)
    {
        return JsonConvert.DeserializeObject<T>(await httpResponseMessage.Content.ReadAsStringAsync());
    }

    private void HandleAuth(IWebHostBuilder builder)
    {
        if (UserIsAuthorized)
        {
            builder.ConfigureTestServices(services =>
            {
                services
                    .AddAuthentication("Authorized")
                    .AddScheme<AuthenticationSchemeOptions, UserAuthorizedHandler>(
                        "Authorized", options => { });
            });
        }
        else if (UserIsAuthenticated)
        {
            builder.ConfigureTestServices(services =>
            {
                services
                    .AddAuthentication("Authenticated")
                    .AddScheme<AuthenticationSchemeOptions, UserAuthenticatedHandler>(
                        "Authenticated", options => { });
            });
        }
        else
        {
            builder.ConfigureTestServices(services =>
            {
                services
                    .AddAuthentication("NoAuth")
                    .AddScheme<AuthenticationSchemeOptions, NoAuthenticationHandler>(
                        "NoAuth", options => { });
                ;
            });
        }
    }

    protected void AuthenticateUser()
    {
        UserIsAuthenticated = true;
    }

    protected void AuthorizeUser()
    {
        UserIsAuthorized = true;
    }
}