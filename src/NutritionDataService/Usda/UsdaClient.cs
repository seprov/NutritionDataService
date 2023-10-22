namespace NutritionDataService.Usda
{
    internal class Client
    {
        private readonly ClientConfiguration _configuration;

        public Client(ClientConfiguration configuration) 
        {
            _configuration = configuration;
        }
    }
}
