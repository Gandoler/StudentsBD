using BDAPP.appui.Login.Model;
using BDAPP.appui.MainPage;
using BDAPP.appui.MainPage.Model;
using BDAPP.appui.MainPage.View;
using BDAPP.appui.MainPage.View.Admin;
using BDAPP.appui.MainPage.View.RegularUser;
using BDAPP.logic.AppSettingsParse.ConectionStringManager;
using BDAPP.logic.DBTools.Managers.Connection;
using BDAPP.logic.DBTools.Managers.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDAPP
{
   static class PresenterObjectBuilder
    {
        public static (PresenterMain?, IMainPageView?) PresenterMainAndView { get; private set; }

        static PresenterObjectBuilder()
        {
            string? connectionString;
            do
            {
                connectionString = ConnectionStringManager.GetConnectionString(User.Instance.Role,"137913");
            } while (connectionString == null);

            ConnectDBManager connectDBManager = new(connectionString);
            CrudManager crudManager = new(connectDBManager);
            MainPageModel mainPageModel = new MainPageModel(crudManager);

            PresenterMain presenter;
            MainPageAdmin admin;
            MainPageRU mainPageRU;
            if (User.Instance.Role == "admin")
            {
                admin = new MainPageAdmin();
                presenter = new PresenterMain(admin, mainPageModel);
                PresenterMainAndView = (presenter, admin);
            }
            else if (User.Instance.Role == "junior")
            {
                mainPageRU = new MainPageRU();
                presenter = new PresenterMain(mainPageRU, mainPageModel);
                PresenterMainAndView = (presenter, mainPageRU);
            }
           
        }
    }
}
