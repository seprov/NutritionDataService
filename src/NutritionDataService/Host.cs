using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NutritionDataService
{
    internal class Host
    {
        public IServiceProvider ServiceProvider
            => new HostBuilder()
                .ConfigureAppConfiguration(ConfigureAppConfiguration)
                .ConfigureServices(ConfigureServices)
                .Build()
                .Services
        ;

        private void ConfigureAppConfiguration(HostBuilderContext context, IConfigurationBuilder configuration)
        {
            configuration
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: false)
                .AddJsonFile("appSettings.Secrets.json", optional: false)
            ;
        }
        private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services
                .AddSingleton(context.Configuration.GetRequiredSection("Usda:ClientConfiguration").Get<Usda.ClientConfiguration>()
                    ?? throw new InvalidOperationException("Failed to get Usda.ClientConfiguration"))
                .AddSingleton<Usda.Client>()
            ;
        }

    }
}
