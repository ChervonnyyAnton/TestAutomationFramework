using DataProvider.Frontend;
using DataProvider.Frontend.Pages;
using Xunit;

namespace Tests.Frontend.Smoke
{
	public class TestCases : TestBase
	{
		[Fact]
		public void ToggleButtonIsDisplayedTest()
		{
			bool isDisplayed = Keywords.Open(TestData.Url).IsDisplayed(MainPage.ToggleButton);
			Assert.True(isDisplayed);
		}
	}
}