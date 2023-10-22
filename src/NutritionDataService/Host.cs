using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NutritionDataService
{
    internal class Host
    {
        public IServiceProvider ServiceProvider => new HostBuilder()
            .ConfigureAppConfiguration(ConfigureAppConfiguration)
            .ConfigureServices(ConfigureServices)
            .Build().Services;

        private void ConfigureAppConfiguration(HostBuilderContext context, IConfigurationBuilder configuration)
        {
            throw new NotImplementedException();
        }
        private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            services
                .AddSingleton<UsdaClient>()
            ;
        }

    }
}
