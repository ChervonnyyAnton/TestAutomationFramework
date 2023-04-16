using DataProvider.RunSettings;

namespace DataProvider.Frontend
{
	public static class TestData
	{
        public static string Url => RunSettingsFromEnvironment.Url;
    }
}