using cleanArchitecture.Core.Interfaces;
using cleanArchitecture.Services.services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace cleanArchitecture.Services
{
    public static class ServicesRegistration
    {
        public static void AddServicesRegistration(this WebApplicationBuilder Builder)
        {

            Builder.Services.AddTransient<ICarServices,CarServices>();
        }
    }
}
