
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Talabat.Core.Entities;
using Talabat.Core.Repositories.Contracts;
using Talabat.Repository;
using Talabat.Repository.Data;

namespace Talabat.APIs
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            builder.Services.AddDbContext<StoreContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Talabat.APIs", Version = "v1" });
            });

            //builder.Services.AddScoped<IProductRepository, ProductRepository>();
            //builder.Services.AddScoped<IProductBrandRepository, ProductBrandRepository>();
            //builder.Services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        
            var app = builder.Build();

            using var Scope = app.Services.CreateScope();
            var Services = Scope.ServiceProvider;
            var Context = Services.GetRequiredService<StoreContext>();
            var LoggerFactory = Services.GetRequiredService<ILoggerFactory>();
            try
            {
                await Context.Database.MigrateAsync();
                await StoreContextSeed.SeedAsync(Context);

            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                var logger = LoggerFactory.CreateLogger<Program>();
                logger.LogError(ex, "An error occurred during migration");
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Talabat.APIs v1"));

            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
