namespace OTSCSERVER.Tools.DBTools.Managers.Login
{
    internal interface ILoginManager
    {
        public bool Login(long login, string passwoerd);
        public bool Registr(long login, string email, string password);

        public void Dispose();
    }
}
