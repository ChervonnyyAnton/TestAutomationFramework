using System.Net;
namespace Tests.Backend.Smoke
{
	public class TestCases : TestBase
	{
		[Theory]
		[InlineData(100, HttpStatusCode.OK)]
		[InlineData(200, HttpStatusCode.OK)]
		[InlineData(300, HttpStatusCode.OK)]
		public async Task GetCatFactReturnsResponseCodeOKTest(int maxLength, HttpStatusCode expectedCode)
		{
            HttpResponseMessage response = await endpoints.GetCatFactsAsync(maxLength);
			HttpStatusCode actualCode = response.StatusCode;
			Assert.Equal(actualCode, expectedCode);
		}

        [Fact]
        public async Task GetDogFactReturnsResponseCodeOKTest()
        {
            HttpResponseMessage response = await endpoints.GetDogFactsAsync();
            HttpStatusCode actualCode = response.StatusCode;
            Assert.Equal(HttpStatusCode.OK, actualCode);
        }
    }
}