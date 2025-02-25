using BDAPP.appui.MainPage.Model;
using BDAPP.appui.MainPage.View;
using BDAPP.appui.MainPage.View.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.appui.MainPage
{ 
    class Presenter
    {
        private readonly IMainPageAdminVeiw _mainPageAdminVeiw;
        private readonly IMainPageViewRu _mainPageViewRu;



        public Presenter(IMainPageAdminVeiw mainPageAdminVeiw, IMainPageViewRu mainPageViewRu)
        {
            _mainPageAdminVeiw = mainPageAdminVeiw;
            _mainPageViewRu = mainPageViewRu;


            #region RegularUser init
            //exit button
            _mainPageViewRu.ExitButtonEntered += () => _mainPageViewRu.MakeExitButtonForeRed();
            _mainPageViewRu.ExitButtonLeavd += () => _mainPageViewRu.MakeExitButtonForeBlack();
            _mainPageViewRu.ExitButtonClick += EXITFUNC;


            #endregion


            #region adminpage init
            //exit button
            _mainPageAdminVeiw.ExitButtonEntered += () => _mainPageAdminVeiw.MakeExitButtonForeRed();
            _mainPageAdminVeiw.ExitButtonLeavd += () => _mainPageAdminVeiw.MakeExitButtonForeBlack();
            _mainPageAdminVeiw.ExitButtonClick += EXITFUNC;

            // admin buttons
            _mainPageAdminVeiw.AddButtonClick += _mainPageAdminVeiw_AddButtonClick;
            _mainPageAdminVeiw.UPDButtonClick += _mainPageAdminVeiw_UPDButtonClick;
            _mainPageAdminVeiw.DELButtonClick += _mainPageAdminVeiw_DELButtonClick;

            //search and Unsearch
            //_mainPageAdminVeiw.SearchButtonClick+=
            //_mainPageAdminVeiw.ClearSearchButtonClick+=

            #endregion
        }

        private void EXITFUNC()
        {
            Application.Exit();
        }



        #region adminpage 
        private void _mainPageAdminVeiw_DELButtonClick(StudentFieldTemplates obj)
        {
            throw new NotImplementedException();
        }

        private void _mainPageAdminVeiw_UPDButtonClick(StudentFieldTemplates obj)
        {
            throw new NotImplementedException();
        }

        private void _mainPageAdminVeiw_AddButtonClick(StudentFieldTemplates obj)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
