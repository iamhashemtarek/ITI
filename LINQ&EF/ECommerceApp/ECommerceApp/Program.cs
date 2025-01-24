using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;

namespace ECommerceApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load configuration from appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            // Initialize application configuration (high-DPI, default font, etc.)
            ApplicationConfiguration.Initialize();

            // Run the main form
            Application.Run(new ECommerceApp.Froms.LoginForm());
        }

        /// <summary>
        /// Global configuration instance.
        /// </summary>
        public static IConfiguration Configuration { get; private set; }
    }
}