// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var serviceProvider = new NutritionDataService.Host().ServiceProvider;

var usdaClient = serviceProvider.GetRequiredService<NutritionDataService.Usda.Client>();
var x = await usdaClient.GetNutritionDataAsync("milk");
Console.WriteLine("");