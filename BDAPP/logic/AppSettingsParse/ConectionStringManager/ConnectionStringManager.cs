using BDAPP.logic.AppSettingsParse.Reader;
using BDAPP.logic.AppSettingsParse.Templaetes;
using Serilog;
using System;

namespace BDAPP.logic.AppSettingsParse.ConectionStringManager
{
    internal static class ConnectionStringManager
    {
        static RootConfig rootConfig = new RootConfig(new ServerSettings());

        static ConnectionStringManager()
        {
            GoDeserialiseObject();
        }
        private static void GoDeserialiseObject()
        {

            JsonReaderForConfig jsonReader = new JsonReaderForConfig();
            try
            {
                rootConfig = jsonReader.Read<RootConfig>();
                Log.Information($"ConnectionStringManager: settings:{rootConfig}");
            }
            catch (Exception ex)
            {
                Log.Error($"In ConnectionStringManager {ex.Message}");
            }

        }

        public static string? GetConnectionString()
        {
            if (rootConfig.ServerSettings != null)
            {
                return rootConfig.ServerSettings.GetConnectionString();
            }
            return null;
        }


       


    }
}
