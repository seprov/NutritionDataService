using NutritionDataService.Model;
using NutritionDataService.Usda.Response;

namespace NutritionDataService.Usda;


internal static class FoodNutrientsToNutritionDataMapper
{
    public enum MacronutrientIds
    {
        Calories = 1008,
        Carbs = 1005,
        Fat = 1004,
        Fiber = 1079,
        Protein = 1003,
        #region Unused
        Sugar = 2000,
        Calcium = 1087,
        Iron = 1089,
        Sodium = 1093
        #endregion
    }

    internal static NutritionData MapFoodNutrientsToNutritionData(Food food)
    {
        var foodNutrients = food.FoodNutrients!;
        var nutritionData = new NutritionData
            (
                food.Description!,
                foodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Calories).First().Value,
                foodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Carbs).First().Value,
                foodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Fat).First().Value,
                foodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Fiber).First().Value,
                foodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Protein).First().Value
            );
        return nutritionData;
    }
}

