using Microsoft.Extensions.DependencyInjection;
using StrategyPatternWithDI.Operations;
using StrategyPatternWithDI.Strategy;
using System;

namespace StrategyPatternWithDI
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();

            var serviceProvider = services.BuildServiceProvider();

            // calls the Run method in App, which is replacing Main
            serviceProvider.GetService<App>().Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddScoped<ICampaignStrategy, CampaignStrategy>();
            services.AddScoped<ICampaign, AmountCampaign>();
            services.AddScoped<ICampaign, RateCampaign>();

            // required to run the application
            services.AddTransient<App>();

            return services;
        }
    }
}
