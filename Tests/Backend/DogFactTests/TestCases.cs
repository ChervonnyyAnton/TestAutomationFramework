using DataProvider.Backend;
using DataProvider.Backend.ResponseDTO;
using Xunit;

namespace Tests.Backend.DogFactTests
{
	public class TestCases : TestBase
	{
        [Fact]
        public void FactIsNotEmptyTest()
        {
            DogFactResponse response = Keywords.GetFact();
            Assert.NotEmpty(response.Fact[0].Attributes.Body);
        }

        [Fact]
        public void LimitOfFactsIsAsExpected()
        {
            DogFactResponse response = Keywords.GetFact(TestData.DogFactLimit);
            Assert.True(response.Fact.Length == TestData.DogFactLimit);
        }
    }
}