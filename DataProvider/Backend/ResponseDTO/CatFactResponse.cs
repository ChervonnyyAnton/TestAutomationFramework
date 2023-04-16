using Newtonsoft.Json;

namespace DataProvider.Backend.ResponseDTO
{
	public class CatFactResponse
	{
		[JsonProperty("fact")]
		public string Fact { get; set; }
        [JsonProperty("length")]
        public int Length { get; set; }
    }
}