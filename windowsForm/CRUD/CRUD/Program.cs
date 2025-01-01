using Microsoft.Extensions.Configuration;

namespace CRUD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //var configuration = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            //Console.WriteLine(configuration.GetSection("constr").Value);

        }
    }
}