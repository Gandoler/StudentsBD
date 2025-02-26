using BDAPP.appui.Login.Model;

namespace BDAPP.logic.DBTools.Managers.Login
{
    internal interface ILoginManager
    {
        public bool Login(string login, string passwoerd);
       

        public void Dispose();
    }
}
