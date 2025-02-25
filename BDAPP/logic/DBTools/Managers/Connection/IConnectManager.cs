using Npgsql;


namespace BDAPP.logic.DBTools.Managers.Connection
{
    internal interface IConnectManager
    {
        void Connect();
        void Disconnect();
        NpgsqlConnection? SqlConnection { get; }


    }
}
