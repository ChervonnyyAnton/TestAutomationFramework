using Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Keywords.Frontend.Keywords
{
	public class CoreKeywords
	{
        private readonly IWebDriver _driver;
        private readonly WebDriverWait _wait;

        public CoreKeywords(IWebDriver driver, int secondsToWait)
        {
            _driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(secondsToWait));
            _wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(StaleElementReferenceException));
            _wait.PollingInterval = TimeSpan.FromMilliseconds(1000);
        }

        public CoreKeywords Open(string url)
        {
            _driver.Navigate().GoToUrl(url);
            AnimationDelay(5);

            return this;
        }

        private IWebElement FindElement(Func<IWebDriver, IWebElement> expectedCondition)
        {
            return _wait.Until(expectedCondition);
        }

        public IWebElement FindElement(By locator)
        {
            return _wait.Until(ExpectedConditions.ToBeClickable(locator));
        }

        public bool IsDisplayed(By locator)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.PollingInterval = TimeSpan.FromMilliseconds(500);

            try
            {
                return wait.Until(_ => _driver.FindElement(locator).Displayed);
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public CoreKeywords Click(By locator)
        {
            FindElement(ExpectedConditions.ToBeClickable(locator)).Click();

            AnimationDelay(1);

            return this;
        }

        public CoreKeywords SendKeys(By locator, string text)
        {
            IWebElement element = FindElement(ExpectedConditions.ToBeClickable(locator));

            element.Clear();
            element.SendKeys(text);

            AnimationDelay(1);

            return this;
        }

        public void AnimationDelay(int timeInSeconds)
        {
            Thread.Sleep(timeInSeconds * 1000);
        }

        internal IWebElement FindElement(object placeholder)
        {
            throw new NotImplementedException();
        }
    }
}