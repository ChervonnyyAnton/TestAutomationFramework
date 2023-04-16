using Tests.Providers;
using Keywords.Frontend.Providers;
using Keywords.Frontend.Keywords;

namespace Tests.Frontend.Smoke
{
	public class TestBase : TestBaseProvider
	{
		protected CoreKeywords Keywords;
        protected DriverProvider Provider;

        protected override void InitializeProviders()
        {
            Provider = new DriverProvider();
            Driver = Provider.SetupChromeDriver();
        }

        protected override void InitializeKeywords()
        {
            Keywords = new CoreKeywords(Driver, 10);
        }
    }
}