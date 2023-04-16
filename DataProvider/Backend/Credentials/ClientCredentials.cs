using DataProvider.RunSettings;
namespace DataProvider.Backend.Credentials
{
	public static class ClientCredentials
	{
		public static string TokenUrl => RunSettingsFromEnvironment.TokenUrl;
		public static string CatFactUrl => RunSettingsFromEnvironment.CatFactUrl;
        public static string DogFactUrl => RunSettingsFromEnvironment.DogFactUrl;
        public static string TenantId => RunSettingsFromEnvironment.TenantId;
		public static string ClientId => RunSettingsFromEnvironment.ClientId;
		public static string Scope => RunSettingsFromEnvironment.Scope;
		public static string GrantType => RunSettingsFromEnvironment.GrantType;
	}
}