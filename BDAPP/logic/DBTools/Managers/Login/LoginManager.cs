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

        public bool Login(string login, string password)
        {
            string query = "SELECT COUNT(*) FROM UsersLogins WHERE login = @Login AND password = @Password";
            Log.Information("Try to Login in LoginManager");

            using (var command = new NpgsqlCommand(query, _connectManager.SqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 1)
                {
                    Log.Information("Log in Successful");
                    return true;
                }
                else
                {
                    Log.Warning("Log in invalid --- Password or Login Incorrect");
                    return false;
                }
            }
        }

     
        public void Dispose()
        {
            _connectManager.Disconnect();
            Log.Information($"Закрыто подключение к дб для {nameof(LoginManager)}");
        }
    }
}