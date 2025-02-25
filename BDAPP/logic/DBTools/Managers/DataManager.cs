using OTSC_ui.Tools.DBTools.Connection;
using OTSC_ui.Tools.DBTools.Operations;
using System.Data;


namespace OTSCSERVER.Tools.DBTools.Managers
{
    internal class DataManager
    {
        private readonly IConnectManager _connectManager;
        private readonly ISqlOperation _sqlOperation;
        public DataManager(IConnectManager ConnectManager, ISqlOperation SqlOperation)
        {
            _connectManager = ConnectManager;
            _sqlOperation = SqlOperation;
            _connectManager.Connect();
        }

        public void InsertData(string query)
        {
            _sqlOperation.Insert(query);
        }


        public void UpdateData(string query)
        {
            _sqlOperation.Update(query);
        }

        public void DeleteData(string query)
        {
            _sqlOperation.Delete(query);
        }

        public DataTable GetDataTable(string query)
        {
            _sqlOperation.Select(query, out var results);
            return results;
        }

        public void CloseConnecction()
        {
            _connectManager.Disconnect();
        }


    }
}
