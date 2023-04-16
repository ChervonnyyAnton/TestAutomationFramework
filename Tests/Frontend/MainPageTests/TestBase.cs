using Keywords.Frontend.Keywords;
using Keywords.Frontend.Providers;
using Tests.Providers;

namespace Tests.Frontend.MainPageTests
{
	public class TestBase : TestBaseProvider
	{
        protected MainKeywords Keywords;
        protected DriverProvider Provider;

        protected override void InitializeProviders()
        {
            Provider = new DriverProvider();
            Driver = Provider.SetupChromeDriver();
        }

        protected override void InitializeKeywords()
        {
            Keywords = new MainKeywords(Driver, 10);
        }
    }
}