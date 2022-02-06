using Business.Managers;
using Core.Managers;
using Core.Repositories;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace App.Web.Extensions
{
    public static class ServiceRegistrationExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddTransient<ICountryManager, CountryManager>();
        }
    }
}
