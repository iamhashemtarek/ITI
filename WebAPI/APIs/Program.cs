
using Core.Entities;
using Core.Repositories.Contract;
using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Data;

namespace APIs
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

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped(typeof(ICourseRepository), typeof(CourseRepository));
            //builder.Services.AddScoped(typeof(IDepartmentRepository), typeof(DepartmentRepository));
            //builder.Services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));
            //builder.Services.AddScoped(typeof(IInstructorRepository), typeof(InstructorRepository));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var _AppDbContext = services.GetRequiredService<AppDbContext>();
            try
            {
                await _AppDbContext.Database.MigrateAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            app.Run();
        }
    }
}
