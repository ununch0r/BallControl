using Business.Managers;
using Core.Managers;
using Core.Providers;
using Core.Repositories;
using DataAccess.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Providers.ApiFootball;
using Providers.ApiFootball.Providers;

namespace App.Web.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddTransient<ICountryManager, CountryManager>();

            services.AddTransient<ICompetitionProvider, CompetitionProvider>();
            services.AddSingleton(new ApiFootballClient(
                configuration["ApiFootball:Host"],
                configuration["ApiFootball:Key"]
                ));
        }
    }
}
