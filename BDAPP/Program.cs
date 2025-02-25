using BDAPP.appui.MainPage.View.RegularUser;
using Serilog;
using System.Diagnostics;

namespace BDAPP
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
            Log.Logger = new LoggerConfiguration()
               .WriteTo.File(@"C:\Users\glkru\OneDrive\Desktop\prj\Project_cpo\User_setup\Logs\myapp.log", rollingInterval: RollingInterval.Day)
               .CreateLogger();


            Log.Information("App start");
            MainPageRU mainPageRU = new MainPageRU();

            Application.Run(mainPageRU);
        }
    }
}