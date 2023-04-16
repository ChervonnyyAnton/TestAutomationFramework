using Helpers;

namespace Keywords.Backend.Providers
{
	public class ClientProvider
	{
		private HttpClient CreateClient(string url)
		{
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(url);
			return client;
		}

		public async Task<HttpResponseMessage> PostAsync(string url, object serializableObject)
		{
			HttpClient client = CreateClient(url);
			string jsonString = Tools.SerializeObject(serializableObject);
			StringContent stringContent = Tools.CreateStringContentFromJsonString(jsonString);

			return await client.PostAsync(client.BaseAddress, stringContent);
		}

		public async Task<HttpResponseMessage> GetAsync(string url)
		{
			HttpClient client = CreateClient(url);

			return await client.GetAsync(client.BaseAddress);
		}

		public async Task<HttpResponseMessage> DeleteAsync(string url)
		{
			HttpClient client = CreateClient(url);

			return await client.DeleteAsync(client.BaseAddress);
		}
	}
}