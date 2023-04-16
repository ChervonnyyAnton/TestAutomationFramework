using Newtonsoft.Json;

namespace DataProvider.Backend.ResponseDTO
{
	public class DogFactResponse
	{
        [JsonProperty("data")]
        public DogFact[] Fact { get; set; }
    }

    public class DogFact
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("attributes")]
        public FactAttributes Attributes { get; set; }
    }

    public class FactAttributes
    {
        [JsonProperty("body")]
        public string Body { get; set; }
    }
}