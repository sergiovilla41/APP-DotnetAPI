using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using MyVaccine.WebApi.Literals;
using MyVaccine.WebApi.Models;

namespace MyVaccine.WebApi.Configurations
{
    public static class DBConfigurations
    {
        public static IServiceCollection SetDatabaseConfiguration(this IServiceCollection services)
        {
            //var ConnectionString = Environment.GetEnvironmentVariable(MyVaccineLiterals.Connection);
            var ConnectionString = "Server = localhost,14330; Database = MyVaccineAppDb; User Id = sa; Password = ABC123456; TrustServerCertificate = True;";
            services.AddDbContext<MyVaccineDbContext>(options =>
                    options.UseSqlServer(ConnectionString)                
            );

            return services;

        }
    }
}
