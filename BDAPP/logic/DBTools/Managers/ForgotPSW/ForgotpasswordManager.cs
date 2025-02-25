using MySql.Data.MySqlClient;
using OTSC_ui.Tools.DBTools.Connection;
using Serilog;


namespace OTSCSERVER.Tools.DBTools.Managers.ForgotPSW
{
    internal class ForgotpasswordManager : IForgotpasswordManager
    {
        private readonly IConnectManager _connectManager;
        public ForgotpasswordManager(IConnectManager ConnectManager)
        {
            _connectManager = ConnectManager;
            _connectManager.Connect();
            Log.Information($"Открыто подключение к дб для {nameof(ForgotpasswordManager)}");
        }


        public bool ChangePassword(string password, string email)
        {
            if (CheckUserExist(email))
            {
                string queryCheckExist = "UPDATE UsersLogins SET password=@Password WHERE email = @Email";
                using (var command = new MySqlCommand(queryCheckExist, _connectManager.SqlConnection))
                {
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        Log.Error($"in {nameof(ChangePassword)}in{nameof(ForgotpasswordManager)}" +
                            $"No rows were updated. The password update may have failed ");
                        throw new Exception("No rows were updated. The password update may have failed.");
                    }
                }
            }
            return false;
        }

        public bool CheckUserExist(string email)
        {
            string queryCheckExist = "SELECT COUNT(*) FROM UsersLogins WHERE email = @Email";
            using (MySqlCommand command = new MySqlCommand(queryCheckExist, _connectManager.SqlConnection))
            {
                command.Parameters.AddWithValue("@Email", email);
                int userCount = Convert.ToInt32(command.ExecuteScalar());
                if (userCount > 0)
                {
                    Log.Information("User exists.");
                    return true;
                }
                else
                {
                    Log.Information("User does not exist.");
                    return false;
                }
            }
            throw new Exception("Unexpected database error");
        }

        public void Dispose()
        {
            _connectManager.Disconnect();

        }
    }
}
