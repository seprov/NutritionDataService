namespace NutritionDataService.Usda;
public class ClientConfiguration
{
	public string Endpoint { get; init; }
	public string ApiKey { get; init; }

	public ClientConfiguration(string endpoint, string apiKey)
	{
		// TODO: add validation
		Endpoint = endpoint;
		ApiKey = apiKey;
	}
}