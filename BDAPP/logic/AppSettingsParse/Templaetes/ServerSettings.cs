using Serilog;

namespace BDAPP.logic.AppSettingsParse.Templaetes
{
    public class ServerSettings : ITemplates
    {
        public string Server { get; set; } = string.Empty;
        public int Port { get; set; }
        public string Database { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public string GetConnectionString()
        {
            if (string.IsNullOrWhiteSpace(Server) ||
                string.IsNullOrWhiteSpace(Database) ||
                string.IsNullOrWhiteSpace(User) ||
                string.IsNullOrWhiteSpace(Password))
            {
                Log.Information("ServerSettings: now in template:" + ToString());
                Log.Error("ServerSettings: One or more required fields are missing for the connection string.");
                return null;
            }
            
            return $"Server={Server};Port={Port};Database={Database};User id={User};Password={Password};";
        }


        public string GetConnectionString(string role, string psw)
        {
            if (string.IsNullOrWhiteSpace(Server) ||
                string.IsNullOrWhiteSpace(Database) ||
                string.IsNullOrWhiteSpace(User) ||
                string.IsNullOrWhiteSpace(Password))
            {
                Log.Information("ServerSettings: now in template:" + ToString());
                Log.Error("ServerSettings: One or more required fields are missing for the connection string.");
                return null;
            }
            if(role == "admin") { return $"Server={Server};Port={Port};Database={Database};User id={"GlFr_admin "};Password={psw};"; }
            return $"Server={Server};Port={Port};Database={Database};User id={"GlFr_junior"};Password={psw};";

        }

        public override string ToString()
        {
            return $"Host={Server}, Port={Port}, Database={Database}, Username={User}, Password={Password}";
        }
    }
}