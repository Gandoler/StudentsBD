using BDAPP.logic.DBTools.Connection;
using Npgsql;
using System.Data;

namespace BDAPP.logic.DBTools.Operations
{
    internal class SqlOperation : ISqlOperation
    {
        private readonly IConnectManager _connectManager;

        public SqlOperation(IConnectManager connectManager)
        {
            _connectManager = connectManager;
        }

        public void Delete(string query)
        {
            ExecuteQuery(query);
        }

        public void Insert(string query)
        {
            ExecuteQuery(query);
        }

        public void Select(string query, out DataTable results)
        {
            results = new DataTable();
            using (var command = new NpgsqlCommand(query, _connectManager.SqlConnection))
            using (var adapter = new NpgsqlDataAdapter(command))
            {
                adapter.Fill(results);
            }
        }

        public void Update(string query)
        {
            ExecuteQuery(query);
        }

        private void ExecuteQuery(string query)
        {
            using (var command = new NpgsqlCommand(query, _connectManager.SqlConnection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}