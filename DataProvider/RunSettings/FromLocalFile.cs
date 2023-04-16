using System.Runtime.CompilerServices;

namespace DataProvider.RunSettings
{
	public static partial class RunSettingsFromEnvironment
	{
		public class RunSettingsParsedFromJsonFile
		{
			private readonly Dictionary<string, string> _values = new();

			public string Url
			{
				set => SetValue(value);
			}

			public string User
			{
				set => SetValue(value);
			}

			public string Password
			{
				set => SetValue(value);
			}

			public string CatFactUrl
			{
				set => SetValue(value);
			}

            public string DogFactUrl
            {
                set => SetValue(value);
            }

            public string TokenUrl
			{
				set => SetValue(value);
			}

			public string TenantId
			{
				set => SetValue(value);
			}

			public string ClientId
			{
				set => SetValue(value);
			}

			public string ClientSecret
			{
				set => SetValue(value);
			}

			public string GrantType
			{
				set => SetValue(value);
			}

			public string Scope
			{
				set => SetValue(value);
			}

			public string GetValue([CallerMemberName] string key = null)
			{
				string value = _values[key];

				if (value == null)
				{
					throw new ArgumentNullException(nameof(value), "There is no value found");
				}

				return value;
			}

			private void SetValue(string value, [CallerMemberName] string key = null)
			{
				_values[key] = value;
			}
		}
	}
}