using NutritionDataService.Model;
using NutritionDataService.Usda.Response;

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

        public async Task<NutritionData> GetNutritionDataAsync(string query)
        {
            var response = await GetResponseAsync(query);
            ValidateResponse(response);
            var food = SelectFood(response!);
            var nutritionData = MapFoodToNutritionData(food);
            return nutritionData;
        }

        private NutritionData MapFoodToNutritionData(Food food)
        {
            var foodNutrients = food.FoodNutrients!;
            var nutritionData = new NutritionData
                (
                    food.Description,
                    foodNutrients.Where(x => x.NutrientId == 1008).FirstOrDefault().Value, // energy, kcal
                    foodNutrients.Where(x => x.NutrientId == 1005).FirstOrDefault().Value, // carb
                    foodNutrients.Where(x => x.NutrientId == 1004).FirstOrDefault().Value, // fat
                    foodNutrients.Where(x => x.NutrientId == 1079).FirstOrDefault().Value, // fib
                    foodNutrients.Where(x => x.NutrientId == 1003).FirstOrDefault().Value  // protein
                                                                                           // sugar = 2000, ca = 1087, fe = 1089, na = 1093
                );
            return nutritionData;
        }

        private void ValidateResponse(Response.RootObject? response) 
        { 
        
        }

        private Response.Food SelectFood(Response.RootObject response)
        {
            return response.Foods![0];
        }

        private async Task<Response.RootObject?> GetResponseAsync(string query)
        {
            Response.RootObject? response = null;
            string url = $"{_configuration.BaseUrl}?query={query}&api_key={_configuration.ApiKey}";

            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync(url);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var responseAsJsonString = await httpResponseMessage.Content.ReadAsStringAsync();
                //JObject data = JObject.Parse(jsonString);
                response = System.Text.Json.JsonSerializer.Deserialize<Response.RootObject>(responseAsJsonString);
                Console.WriteLine(responseAsJsonString);
            }
            else
            {
                Console.WriteLine("Error fetching data: " + httpResponseMessage.StatusCode);
            }

            return response;
        }
    }
}
