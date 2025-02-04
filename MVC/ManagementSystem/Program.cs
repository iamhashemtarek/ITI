namespace ManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // MVC - register MVC services to the container
            //builder.Services.AddRazorPages(); // Razor Pages - register Razor Page services to the container
            //builder.Services.AddControllers(); // Web APIs - register Web APIs services to the container

            // mvc + webapis + razor ==> builder.Services.AddMvc(); 
                    
            

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }  
            app.UseStaticFiles();
                
            app.UseRouting();
            
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); // id is optional

            app.Run();
        }
    }
}
