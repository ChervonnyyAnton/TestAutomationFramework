using System.Text;
using Newtonsoft.Json;

namespace Helpers
{
	public static class Tools
	{
        public static StringContent CreateStringContentFromJsonString(string jsonString)
        {
            return new StringContent(jsonString, Encoding.UTF8, "application/json");
        }

        public static string GetContentFromResponseMessage(HttpResponseMessage response)
        {
            return response.Content.ReadAsStringAsync().Result;
        }

        public static T DeserializeResponse<T>(HttpResponseMessage response) where T : class
		{
			string json = GetContentFromResponseMessage(response);

			return JsonConvert.DeserializeObject<T>(json)!;
		}

		public static string SerializeObject(object serializableObject)
		{
			return JsonConvert.SerializeObject(serializableObject);
		}
    }
}