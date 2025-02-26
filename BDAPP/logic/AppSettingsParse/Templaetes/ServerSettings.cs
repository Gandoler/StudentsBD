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

        public string? GetConnectionString()
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


        public string? GetConnectionString(string role, int psw)
        {
            string password = psw.ToString();  // Преобразуем пароль в строку

            if (string.IsNullOrWhiteSpace(Server) ||
                string.IsNullOrWhiteSpace(Database) ||
                string.IsNullOrWhiteSpace(User) ||
                string.IsNullOrWhiteSpace(Password))
            {
                Log.Information("ServerSettings: now in template:" + ToString());
                Log.Error("ServerSettings: One or more required fields are missing for the connection string.");
                return null;
            }
            if (role == "admin")
            {
                return $"Server={Server};Port={Port};Database={Database};User id=glfr_admin;Password={password};";
            }
            else if (role == "junior")
            {
                return $"Server={Server};Port={Port};Database={Database};User id=glfr_junior;Password={password};";
            }
            MessageBox.Show("Ваш аккаунт нераспознан базовые функции выключены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return $"Server={Server};Port={Port};Database={Database};User id={User};Password={Password};";
        }

        public override string ToString()
        {
            return $"Host={Server}, Port={Port}, Database={Database}, Username={User}, Password={Password}";
        }
    }
}