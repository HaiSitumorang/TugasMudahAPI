using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using INetCoreAPI.Service.Interface.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreAPI.Service.Services;

namespace NetCoreAPI.Service
{
    public class ServiceDepedencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaService, MahasiswaServices>();
            services.AddScoped<IDBService, DBService>();
        }
    }
}
