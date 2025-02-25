using MySql.Data.MySqlClient;


namespace OTSC_ui.Tools.DBTools.Connection
{
    internal interface IConnectManager
    {
        void Connect();
        void Disconnect();
        MySqlConnection? SqlConnection { get; }


    }
}
