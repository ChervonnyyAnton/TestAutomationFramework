using Tests.Providers;
using Keywords.Backend.Providers;
namespace Tests.Backend.Smoke
{
	public class TestBase : TestBaseProvider
	{
		protected EndpointProvider endpoints;
        protected override void InitializeProviders()
        {
            endpoints = new EndpointProvider();
        }
	}
}