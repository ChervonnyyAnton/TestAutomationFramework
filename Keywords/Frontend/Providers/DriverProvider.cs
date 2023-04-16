using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Keywords.Frontend.Providers
{
	public class DriverProvider
	{
            public IWebDriver SetupChromeDriver()
            {
                ChromeOptions options = new ChromeOptions();

                Dictionary<string, object> browserStackOptions = new Dictionary<string, object>
            {
                { "resolution", "1920x1080" },
                { "seleniumVersion", "4.6.0" }
            };

                options.AddAdditionalOption("bstack:options", browserStackOptions);
                new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), "MatchingBrowser");
                ChromeDriver driver = new ChromeDriver(options);
                driver.Manage().Window.Size = new Size(1920, 1080);
                driver.Manage().Cookies.DeleteAllCookies();
                return driver;
            }
        }
}

