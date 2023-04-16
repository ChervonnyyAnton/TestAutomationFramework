namespace Keywords.Backend.Providers
{
	public class EndpointProvider
	{
		private readonly ClientProvider _clientProvider;

		public EndpointProvider()
		{
			_clientProvider = new ClientProvider();
		}

        public async Task<HttpResponseMessage> GetCatFactsAsync(int? maxLength = null)
		{
			HttpResponseMessage response = await _clientProvider.GetAsync(UrlProvider.GetCatFactUrl(maxLength));
			return response;
		}

        public async Task<HttpResponseMessage> GetDogFactsAsync(int? limit = null)
        {
            HttpResponseMessage response = await _clientProvider.GetAsync(UrlProvider.GetDogFactUrl(limit));
            return response;
        }
    }
}