using DataProvider.RunSettings;
using OpenQA.Selenium;

namespace Tests.Providers
{
	public abstract class TestBaseProvider : IDisposable
	{
		private const string LocalFallbackStageToUse = "Test";
		protected IWebDriver Driver;

		protected TestBaseProvider()
		{
			InitializeRunSettings();
			InitializeProviders();
			InitializeKeywords();
		}

		protected virtual void InitializeRunSettings()
		{
			RunSettingsFromEnvironment.InitializeSettings(LocalFallbackStageToUse);
		}

		protected virtual void InitializeProviders()
		{

		}

		protected virtual void InitializeKeywords()
		{

		}

		public void Dispose()
		{
			Driver?.Dispose();
            GC.SuppressFinalize(this);
		}
	}
}