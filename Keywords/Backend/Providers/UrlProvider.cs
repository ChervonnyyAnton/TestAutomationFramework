using DataProvider.Backend.Credentials;
namespace Keywords.Backend.Providers
{
	public static class UrlProvider
	{
        public static string GetCatFactUrl(int? maxLength = null)
		{
			string url = maxLength != null ? $"/fact?max_length={maxLength}" : "/fact";
			
			return ClientCredentials.CatFactUrl + url;
		}

        internal static string GetDogFactUrl(int? limit)
        {
            string url = limit!= null ? $"/facts?limit={limit}" : "/facts";

            return ClientCredentials.DogFactUrl + url;
        }
    }
}