// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using NutritionDataService;


Console.WriteLine("Hello, World!");

var serviceProvider = new Host().ServiceProvider;

var usdaClient = serviceProvider.GetRequiredService<NutritionDataService.Usda.Client>();
var x = await usdaClient.GetNutritionDataAsync("cheese");
Console.WriteLine("");