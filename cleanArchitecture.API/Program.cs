using cleanArchitecture.Infrastructure;
using cleanArchitecture.Infrastructure.Data;
using cleanArchitecture.Services;
using Microsoft.EntityFrameworkCore;

namespace cleanArchitecture.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // services registration (IService collection)

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.AddInfrastructureRegistration();
            builder.AddServicesRegistration();

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer("");
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}