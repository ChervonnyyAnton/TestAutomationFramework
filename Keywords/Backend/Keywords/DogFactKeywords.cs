using DataProvider.Backend.ResponseDTO;
using Helpers;
using Keywords.Backend.Providers;

namespace Keywords.Backend.Keywords
{
	public class DogFactKeywords
	{
        EndpointProvider Endpoints;

        public DogFactKeywords()
        {
            Endpoints = new EndpointProvider();
        }

        public DogFactResponse GetFact(int? limit = null)
        {
            HttpResponseMessage response = Endpoints.GetDogFactsAsync(limit).GetAwaiter().GetResult();

            return Tools.DeserializeResponse<DogFactResponse>(response);
        }
    }
}