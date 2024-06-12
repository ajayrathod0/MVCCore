using Microsoft.Extensions.DependencyInjection;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RegisterServices
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductRepositories, ProductRepositories>();
            services.AddScoped<IProductBL, ProductBL>();
        }
    }
}
