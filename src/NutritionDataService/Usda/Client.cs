namespace NutritionDataService.Usda
{
    internal class Client
    {
        private readonly ClientConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public Client(ClientConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<string?> GetNutritionData(string foodName)
        {
            string? jsonString = null;
            string url = $"{_configuration.BaseUrl}?query={foodName}&api_key={_configuration.ApiKey}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                jsonString = await response.Content.ReadAsStringAsync();
                //JObject data = JObject.Parse(jsonString);
                Console.WriteLine(jsonString);

            }
            else
            {
                Console.WriteLine("Error fetching data: " + response.StatusCode);
            }

            return jsonString;
        }
    }
}
