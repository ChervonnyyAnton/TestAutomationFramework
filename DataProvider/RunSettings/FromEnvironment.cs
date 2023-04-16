using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace DataProvider.RunSettings
{
	public static partial class RunSettingsFromEnvironment
	{
		private const string FallbackFilePathStub = @"../../../../DataProvider/RunSettings/RunSettings.{0}.local.json";
		private static RunSettingsParsedFromJsonFile _runSettingsParsedFromJsonSettings;
		private static string _stage;

		private static string Stage
		{
			get
			{
				VerifyIsInitialized();
				return _stage;
			}
			set => _stage = value;
		}

		public static string Url => GetValue();
		public static string User => GetValue();
		public static string Password => GetValue();
		public static string CatFactUrl => GetValue();
        public static string DogFactUrl => GetValue();
        public static string TokenUrl => GetValue();
		public static string TenantId => GetValue();
		public static string ClientId => GetValue();
		public static string ClientSecret => GetValue();
		public static string GrantType => GetValue();
		public static string Scope => GetValue();

		private static readonly Dictionary<string, string> Values = new();

		private static string GetValue([CallerMemberName] string key = null)
		{
			VerifyIsInitialized();
			var result = Values[key];
			if (!string.IsNullOrEmpty(result))
			{
				return result;
			}

			EnsureJsonSettings(Stage);
			var resultFromJson = _runSettingsParsedFromJsonSettings.GetValue(key);
			if (string.IsNullOrEmpty(resultFromJson))
			{
				throw new InvalidOperationException("No value exists for " + key);
			}

			return Values[key] = resultFromJson;
		}

		private static void VerifyIsInitialized()
		{
			if (_stage == null)
			{
				throw new InvalidOperationException($"{nameof(InitializeSettings)} needs to be called prior to work with properties.");
			}
		}

		public static void InitializeSettings(string stage)
		{
			Stage = stage;
			ReadValuesFromOperatingSystemEnvironment();
		}

		private static void EnsureJsonSettings(string stage)
		{
			if (_runSettingsParsedFromJsonSettings != null)
			{
				return;
			}

			ReadFromJsonFile(stage);
		}

		private static void ReadFromJsonFile(string stage)
		{
			string filePath = string.Format(FallbackFilePathStub, stage);
			using StreamReader file = File.OpenText(filePath);
            JsonSerializer serializer = new JsonSerializer();
			_runSettingsParsedFromJsonSettings =
				(RunSettingsParsedFromJsonFile)serializer
					.Deserialize(file, typeof(RunSettingsParsedFromJsonFile));
		}

		private static void ReadValuesFromOperatingSystemEnvironment()
		{
			Values[nameof(Url)] = Environment.GetEnvironmentVariable(nameof(Url));
			Values[nameof(User)] = Environment.GetEnvironmentVariable(nameof(User));
			Values[nameof(Password)] = Environment.GetEnvironmentVariable(nameof(Password));
			Values[nameof(CatFactUrl)] = Environment.GetEnvironmentVariable(nameof(CatFactUrl));
            Values[nameof(DogFactUrl)] = Environment.GetEnvironmentVariable(nameof(DogFactUrl));
            Values[nameof(TokenUrl)] = Environment.GetEnvironmentVariable(nameof(TokenUrl));
			Values[nameof(TenantId)] = Environment.GetEnvironmentVariable(nameof(TenantId));
			Values[nameof(ClientId)] = Environment.GetEnvironmentVariable(nameof(ClientId));
			Values[nameof(ClientSecret)] = Environment.GetEnvironmentVariable(nameof(ClientSecret));
			Values[nameof(GrantType)] = Environment.GetEnvironmentVariable(nameof(GrantType));
			Values[nameof(Scope)] = Environment.GetEnvironmentVariable(nameof(Scope));
		}
	}
}