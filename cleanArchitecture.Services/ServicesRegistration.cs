using cleanArchitecture.Core.Interfaces;
using cleanArchitecture.Services.services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanArchitecture.Services
{
    public static class ServicesRegistration
    {
        public static void AddServicesRegistration(this WebApplicationBuilder Builder)
        {

            Builder.Services.AddTransient<ICarServices, CarServices>();
        }
    }
}
