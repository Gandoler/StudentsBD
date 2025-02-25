using Serilog;
using System.Data;

namespace OTSC_ui.Tools.DBTools.Connection
{
    internal class ConnectDBManager : IConnectManager
    {
        private readonly string _connectionString;
        private NpgsqlConnection _connection;

        public MySqlConnection? SqlConnection
        {
            get
            {
                if (_connection == null)
                {
                    Connect();
                }
                else if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open(); 
                }
                else if (_connection.State == ConnectionState.Broken)
                {
                    _connection.Close();
                    Connect();
                }

                return _connection;
            }
        }

        public ConnectDBManager(string conectionString)
        {
            _connectionString = conectionString;
        }


        public void Connect()
        {
            _connection = new MySqlConnection(_connectionString);
            try
            {
                _connection.Open();
                string query = "Use Users";
                MySqlCommand command = new MySqlCommand(query, _connection);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                
                // Обработка MySQL исключений
                Log.Error("MySQL error occurred: " + ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                // Обработка исключений, возникающих при некорректной операции
                Log.Error("Invalid operation: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Обработка всех остальных исключений
                Log.Error("An unexpected error occurred: " + ex.Message);
            }
            
        }

        public void Disconnect()
        {
            if (_connection != null)
            {
                try
                {
                    _connection.Close();
                }
                catch (MySqlException ex)
                {
                    // Обработка исключений, возникающих при закрытии соединения
                    Log.Error("An error occurred while closing the connection: " + ex.Message);
                }
                finally
                {
                    _connection = null;
                }
            }
        }
    }
}
