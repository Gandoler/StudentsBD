using Npgsql;


namespace BDAPP.logic.DBTools.Connection
{
    internal interface IConnectManager
    {
        void Connect();
        void Disconnect();
        NpgsqlConnection? SqlConnection { get; }


    }
}
