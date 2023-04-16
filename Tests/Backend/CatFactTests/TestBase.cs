using Keywords.Backend.Keywords;
using Tests.Providers;

namespace Tests.Backend.CatFactTests
{
	public class TestBase : TestBaseProvider
	{
        protected CatFactKeywords Keywords;
        protected override void InitializeProviders()
        {
            Keywords = new CatFactKeywords();
        }
    }
}