using DataProvider.Backend.ResponseDTO;
using Helpers;
using Keywords.Backend.Providers;

namespace Keywords.Backend.Keywords
{
	public class CatFactKeywords
	{
        EndpointProvider Endpoints;

        public CatFactKeywords()
		{
            Endpoints = new EndpointProvider();
        }

        public CatFactResponse GetFact(int? length = null)
        {
            HttpResponseMessage response = Endpoints.GetCatFactsAsync(length).GetAwaiter().GetResult();

            return Tools.DeserializeResponse<CatFactResponse>(response);
        }
	}
}