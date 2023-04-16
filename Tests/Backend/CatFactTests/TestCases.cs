using DataProvider.Backend;
using DataProvider.Backend.ResponseDTO;
using Xunit;

namespace Tests.Backend.CatFactTests
{
	public class TestCases : TestBase
	{
		[Fact]
		public void FactLengthIsCorrectTest()
		{
			CatFactResponse response = Keywords.GetFact(TestData.CatFactMaxLength);
			Assert.True(response.Fact.Length == response.Length);
		}

        [Fact]
        public void FactLengthIsAsExpectedTest()
        {
            CatFactResponse response = Keywords.GetFact(TestData.CatFactMaxLength);
            Assert.True(response.Length <= TestData.CatFactMaxLength);
        }
    }
}