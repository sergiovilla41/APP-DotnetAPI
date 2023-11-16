using Microsoft.EntityFrameworkCore;
using MyVaccine.WebApi.Literals;
using MyVaccine.WebApi.Models;

namespace MyVaccine.WebApi.Configurations
{
    public static class DBConfigurations
    {
        public static IServiceCollection SetDatabaseConfiguration(this IServiceCollection services)
        {
            var ConnectionString = Environment.GetEnvironmentVariable(MyVaccineLiterals.Connection);
            services.AddDbContext<MyVaccineDbContext>(options =>
                    options.UseSqlServer(ConnectionString)                
            );

            return services;

        }
    }
}
