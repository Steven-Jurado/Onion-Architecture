using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Onion.Architectura.Persistence.Contexts;
using Onion.Architecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Architectura.Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    options => options.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)
                ));

            #region Repositories
            
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(Repository.RepositoryAsync<>));

            #endregion

        }
    }
}
