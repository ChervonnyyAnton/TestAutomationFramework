using DataProvider.Frontend.Structures;
using OpenQA.Selenium;

namespace DataProvider.Frontend.Pages
{
	public static class MainPage
	{
        public static readonly By ToggleButton = By.XPath("//*[@id = 'theme-toggle']");
        public static readonly By Placeholder = By.XPath("//*[@id = 'fact-placeholder']");
        public static Func<Pet, By> PetPicture = pet => By.XPath($"//*[@id = '{DefinePet(pet)}-picture']");
        public static Func<Pet, string> DefinePet = pet => pet == Pet.cat ? "cat" : "dog";
    }
}