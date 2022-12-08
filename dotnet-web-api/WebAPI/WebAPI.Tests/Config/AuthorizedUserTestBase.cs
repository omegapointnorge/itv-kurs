namespace WebAPI.Tests.Config
{
    public abstract class AuthorizedUserTestBase : WebApiTestBase
    {
        public override void Given()
        {
            AuthorizeUser();
            AuthenticateUser();
        }
    }
}