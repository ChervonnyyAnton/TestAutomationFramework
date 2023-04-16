using Keywords.Backend.Keywords;
using Tests.Providers;

namespace Tests.Backend.DogFactTests
{
    public class TestBase : TestBaseProvider
    {
        protected DogFactKeywords Keywords;

        protected override void InitializeProviders()
        {
            Keywords = new DogFactKeywords();
        }
    }
}