using MultipleImpOneInterface.Api.Enum;
using MultipleImpOneInterface.Api.Service;

namespace MultipleImpOneInterface.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<HumanEatService>();
            builder.Services.AddScoped<AnimalEatService>();

            builder.Services.AddTransient<EatServiceResolver>(serviceProvider => key =>
            {
                switch (key)
                {
                    case AnimalType.Animal:
                        return serviceProvider.GetService<AnimalEatService>();
                    case AnimalType.Human:
                        return serviceProvider.GetService<HumanEatService>();
                    default:
                        throw new KeyNotFoundException();
                }
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}