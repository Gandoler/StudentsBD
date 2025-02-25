namespace OTSCSERVER.Tools.DBTools.Managers.ForgotPSW
{
    internal interface IForgotpasswordManager
    {
        public bool ChangePassword(string password, string email);
        public bool CheckUserExist(string email);
        public void Dispose();
    }
}
