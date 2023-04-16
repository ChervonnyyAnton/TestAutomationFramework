using DataProvider.Frontend;
using DataProvider.Frontend.Pages;
using DataProvider.Frontend.Structures;
using OpenQA.Selenium;

namespace Keywords.Frontend.Keywords
{
	public class MainKeywords
	{
        public readonly CoreKeywords Core;

        public MainKeywords(IWebDriver client, int seconds)
        {
            Core = new CoreKeywords(client, seconds);
        }

        public MainKeywords OpenMainPage()
        {
            Core.Open(TestData.Url);

            return this;
        }

        public string GetPlaceholderValue()
        {
            IWebElement placeholder = Core.FindElement(MainPage.Placeholder);
            return placeholder.Text;
        }

        public MainKeywords ClickOn(Pet pet)
        {
            Core.Click(MainPage.PetPicture(pet)).AnimationDelay(2);
            return this;
        }
    }
}