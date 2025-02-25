using Npgsql;
using Serilog;
using System.Data;

namespace BDAPP.logic.DBTools.Managers.Connection
{
    internal class ConnectDBManager : IConnectManager
    {
        private readonly string _connectionString;
        private NpgsqlConnection? _connection;

        public NpgsqlConnection? SqlConnection
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
            try
            {
                _connection = new NpgsqlConnection(_connectionString);
                _connection.Open();

                
                string query = "SET search_path TO STUDENTSNEW";
                using (var command = new NpgsqlCommand(query, _connection))
                {
                    command.ExecuteNonQuery();
                }

                Log.Information("Connection to PostgreSQL database established.");
            }
            catch (NpgsqlException ex)
            {
                Log.Error("PostgreSQL error occurred: " + ex.Message);
                throw;
            }
            catch (InvalidOperationException ex)
            {
                Log.Error("Invalid operation: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Log.Error("An unexpected error occurred: " + ex.Message);
                throw;
            }
        }

        public void Disconnect()
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                try
                {
                    _connection.Close();
                    Log.Information("Connection to PostgreSQL database closed.");
                }
                catch (NpgsqlException ex)
                {
                    Log.Error("An error occurred while closing the connection: " + ex.Message);
                }
                finally
                {
                    _connection.Dispose();
                    _connection = null;
                }
            }
        }
    }
}
