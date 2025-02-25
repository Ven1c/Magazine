using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Domain.Services;

namespace Magazine.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection
            services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<MagazineDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IMagazineDbContext>(provider =>
                provider.GetService<MagazineDbContext>());
            return services;
        }
    }
}
