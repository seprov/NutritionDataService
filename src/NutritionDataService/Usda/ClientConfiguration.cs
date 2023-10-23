namespace NutritionDataService.Usda;
public class ClientConfiguration
{
    public string BaseUrl { get; init; }
    public string ApiKey { get; init; }

    public ClientConfiguration(string baseUrl, string apiKey)
    {
        // TODO: add validation
        BaseUrl = baseUrl;
        ApiKey = apiKey;
    }
}