using NutritionDataService.Model;
using NutritionDataService.Usda.Response;

namespace NutritionDataService.Usda;


internal static class FoodNutrientsToNutritionDataMapper
{
    public enum MacronutrientIds
    {
        Calories = 1008,
        Carbs = 1005,
        Fat = 1004, //1085?
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
        var nutritionData = new NutritionData
            (
                food.Description!,
                food.FoodNutrients!.Where(x => x.NutrientId == (int)MacronutrientIds.Calories).FirstOrDefault()?.Value,
                food.FoodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Carbs).FirstOrDefault()?.Value,
                food.FoodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Fat).FirstOrDefault()?.Value,
                food.FoodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Fiber).FirstOrDefault()?.Value,
                food.FoodNutrients.Where(x => x.NutrientId == (int)MacronutrientIds.Protein).FirstOrDefault()?.Value
            );

        return nutritionData;
    }
}

