using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreAPI.Data.Interface.Repositories;
using NetCoreAPI.Data.Repositories;

namespace NetCoreAPI.Data
{
    public class DataDepedencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaRepository, MahasiswaRepository>();
        }
    }
}
