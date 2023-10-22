namespace NutritionDataService.Model
{
    public record NutritionData
        (
            string FoodName,
            float Calories,
            float Carbs,
            float Fat,
            float Fiber,
            float Protein
        );
}
