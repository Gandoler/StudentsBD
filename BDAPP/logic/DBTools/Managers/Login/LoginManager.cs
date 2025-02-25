using MySql.Data.MySqlClient;
using OTSC_ui.Tools.DBTools.Connection;
using Serilog;


namespace OTSCSERVER.Tools.DBTools.Managers.Login
{
    internal class LoginManager : ILoginManager
    {
        private readonly IConnectManager _connectManager;
        public LoginManager(IConnectManager ConnectManager)
        {
            _connectManager = ConnectManager;
            _connectManager.Connect();
            Log.Information($"Открыто подключение к дб для {nameof(LoginManager)}");
        }

        public bool Login(long login, string passwoerd)
        {
            string query = $"SELECT * FROM UsersLogins WHERE login = @Login AND password = @Password";
            Log.Information("Try to Login in LoginManager");
            using (MySqlCommand command = new MySqlCommand(query, _connectManager.SqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", passwoerd);
                int execute = Convert.ToInt32(command.ExecuteScalar());
                if (execute != 1)
                {
                    Log.Information("Log in Successfull");
                    return true;
                }
                else if (execute == 0)
                {
                    Log.Warning("Log in invalid ---Password Or Login Incorrect");
                    return false;
                }
            }
            Log.Warning("Error with Command");
            throw new Exception("Unexpected database error");



        }
        private bool CheckUserDidntExist(long login, string email)
        {
            string queryCheckExist = $"SELECT * FROM UsersLogins WHERE login = @Login or email  =@EMAIL";
            using (MySqlCommand command = new MySqlCommand(queryCheckExist, _connectManager.SqlConnection))
            {
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@EMAIL", email);
                int execute = Convert.ToInt32(command.ExecuteScalar());
                if (execute != 0)
                {
                    Log.Information("User EXIST");
                    return false;
                }
                else if (execute == 0)
                {

                    return true;
                }
            }
            throw new Exception("Unexpected database error");
        }


        public bool Registr(long login, string email, string passwoerd)
        {
            string queryRegistr = $"INSERT INTO UsersLogins (login,email, password) VALUES (@Login, @Email, @Password)";
            Log.Information("Try to Regsitr in LoginManager");
            if (CheckUserDidntExist(login, email))
            {
                using (MySqlCommand command = new MySqlCommand(queryRegistr, _connectManager.SqlConnection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", passwoerd);
                    command.ExecuteNonQuery();
                    return true;
                }
                throw new Exception("Unexpected database error");
            }
            return false;

        }




        public void Dispose()
        {
            _connectManager.Disconnect();
        }

    }
}
