using OpenQA.Selenium;
namespace Helpers
{
	public static class ExpectedConditions
	{
        public static Func<IWebDriver, IWebElement> IsVisible(By locator)
        {
            return delegate (IWebDriver driver)
            {
                try
                {
                    return ElementIfVisible(driver.FindElement(locator));
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
        }

        public static Func<IWebDriver, IWebElement> ToBeClickable(By locator)
        {
            return delegate (IWebDriver driver)
            {
                IWebElement webElement = ElementIfVisible(driver.FindElement(locator));

                try
                {
                    return webElement.Enabled ? webElement : null;
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
        }

        private static IWebElement ElementIfVisible(IWebElement element)
        {
            return !element.Displayed ? null : element;
        }
    }
}