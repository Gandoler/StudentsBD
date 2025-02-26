using BDAPP.appui.Login;
using BDAPP.appui.MainPage;
using BDAPP.appui.MainPage.Model;
using BDAPP.appui.MainPage.View.Admin;
using BDAPP.appui.MainPage.View.RegularUser;
using BDAPP.logic;
using BDAPP.logic.AppSettingsParse.ConectionStringManager;
using BDAPP.logic.DBTools.Managers.Connection;
using BDAPP.logic.DBTools.Managers.CRUD;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using Serilog;
using System.Data;
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
               .WriteTo.File(@"C:\Users\glkru\source\repos\BDAPP\BDAPP\Log\myapp.log", rollingInterval: RollingInterval.Day)
               .CreateLogger();


            Log.Information("App start");


            if(PresenterObjectBuilder.PresenterMainAndView.Item2 is Form startform)
            Application.Run(startform);




            //ExecuteQueryAndLogResult();
        }




        //    private static void ExecuteQueryAndLogResult()
        //    {
        //        string query = @"
        //    SELECT table_name 
        //    FROM information_schema.tables 
        //    WHERE table_schema = 'public';
        //";

        //        var connectionString = "Server=5.144.179.242;Port=6034;Database=STUDENTSNEW;User id =postgres;Password=Gtybc001;";

        //        DataTable dataTable = new DataTable();
        //        using (var connection = new NpgsqlConnection(connectionString))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                Log.Information("Подключение к базе данных успешно установлено.");

        //                using (var command = new NpgsqlCommand(query, connection))
        //                {
        //                    using (var reader = command.ExecuteReader())
        //                    {
        //                        dataTable.Load(reader);
        //                    }
        //                }

        //                // Логируем результаты
        //                if (dataTable.Rows.Count > 0)
        //                {
        //                    foreach (DataRow row in dataTable.Rows)
        //                    {
        //                        string tableName = row["table_name"].ToString();
        //                        Log.Information($"Найдена таблица: {tableName}");
        //                    }
        //                }
        //                else
        //                {
        //                    Log.Information("Таблицы не найдены.");
        //                }
        //            }
        //            catch (NpgsqlException ex)
        //            {
        //                Log.Error("Ошибка при подключении к базе данных: " + ex.Message);
        //                Log.Error("Stack trace: " + ex.StackTrace);
        //            }
        //            catch (Exception ex)
        //            {
        //                Log.Error("Неизвестная ошибка: " + ex.Message);
        //                Log.Error("Stack trace: " + ex.StackTrace);
        //            }
        //        }
        //    }


        //    public static void ExecuteQueryAndLogResult2()
        //    {
        //        using (var connection = new NpgsqlConnection($"Host=5.144.179.242;Port=6043;Username=postgres;Password=Gtybc001;"))
        //        {
        //            try
        //            {
        //                connection.Open();
        //                // Get all schemas
        //                string getSchemasQuery = "SELECT schema_name FROM information_schema.schemata;";
        //                using (var commandSchemas = new NpgsqlCommand(getSchemasQuery, connection))
        //                using (var readerSchemas = commandSchemas.ExecuteReader())
        //                {
        //                    while (readerSchemas.Read())
        //                    {
        //                        string schemaName = readerSchemas.GetString(0);
        //                        Log.Information($"Schema: {schemaName}");

        //                        // Get all tables for the current schema
        //                        string getTablesQuery = $@"
        //                    SELECT table_name 
        //                    FROM information_schema.tables 
        //                    WHERE table_schema = '{schemaName}';";
        //                        using (var commandTables = new NpgsqlCommand(getTablesQuery, connection))
        //                        using (var readerTables = commandTables.ExecuteReader())
        //                        {
        //                            while (readerTables.Read())
        //                            {
        //                                string tableName = readerTables.GetString(0);
        //                                Log.Information($"Table: {tableName}");
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Log.Error("Ошибка при выполнении запроса: " + ex.Message);
        //            }
        //        }
        //    }


        //}
    }
}