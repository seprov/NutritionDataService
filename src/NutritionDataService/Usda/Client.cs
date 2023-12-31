﻿using NutritionDataService.Model;

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
            var nutritionData = FoodNutrientsToNutritionDataMapper.MapFoodNutrientsToNutritionData(food);
            return nutritionData;
        }

        private void ValidateResponse(Response.RootObject? response)
        {

        }

        private Response.Food SelectFood(Response.RootObject response)
        {
            return response.Foods![0];
        }

        private async Task<Response.RootObject?> GetResponseAsync(string query, bool filterFoundation = true)
        {
            Response.RootObject? response = null;
            string url = $"{_configuration.BaseUrl}?query={query}{(filterFoundation ? "&dataType=Foundation" : null)}&api_key={_configuration.ApiKey}";

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
