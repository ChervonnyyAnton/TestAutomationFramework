using DataProvider.Frontend.Pages;
using DataProvider.Frontend.Structures;
using Xunit;

namespace Tests.Frontend.MainPageTests
{
	public class TestCases : TestBase
	{
        [Theory]
        [InlineData(Pet.cat)]
        [InlineData(Pet.dog)]
        public void AfterClickOnPetPictureTheFactIsDisplayedTest(Pet pet)
        {
            string placeholderBefore = Keywords.OpenMainPage().GetPlaceholderValue();

            string placeHolderAfter = Keywords.ClickOn(pet).GetPlaceholderValue();

            Assert.NotEqual(placeholderBefore, placeHolderAfter);
        }
    }
}