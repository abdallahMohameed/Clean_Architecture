using cleanArchitecture.Core.Interfaces;
using cleanArchitecture.Infrastructure.Presistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace cleanArchitecture.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static void AddInfrastructureRegistration(this WebApplicationBuilder Builder)
        {
            
            Builder.Services.AddTransient(typeof(IRepository<>),typeof(Repository<>));
        }
    }
}
