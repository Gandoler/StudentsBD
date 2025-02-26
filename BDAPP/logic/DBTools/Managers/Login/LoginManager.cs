using BDAPP.appui.Login.Model;
using BDAPP.logic.DBTools.Managers.Connection;
using Npgsql;
using Serilog;

namespace BDAPP.logic.DBTools.Managers.Login
{
    internal class LoginManager : ILoginManager, IDisposable
    {
        private readonly IConnectManager _connectManager;

        public LoginManager(IConnectManager connectManager)
        {
            _connectManager = connectManager;
            _connectManager.Connect();
            Log.Information($"Открыто подключение к дб для {nameof(LoginManager)}");
        }

        public bool Login(string username, string password)
        {
            string query = "SELECT user_id, username, role FROM app_users WHERE username = @username AND password = @password";  // убрал кавычки вокруг параметров

            Log.Information("Try to Login in LoginManager");

            using (var command = new NpgsqlCommand(query, _connectManager.SqlConnection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        User.Instance.UserId = reader.GetInt32(0);
                        User.Instance.Username = reader.GetString(1);
                        User.Instance.Role = reader.GetString(2);
                        return true;
                    }
                }
            }
            return false;
        }
        

        public void Dispose()
        {
            _connectManager.Disconnect();
            Log.Information($"Закрыто подключение к дб для {nameof(LoginManager)}");
        }
    }
}