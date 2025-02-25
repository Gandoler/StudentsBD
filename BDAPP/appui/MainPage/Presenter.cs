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
        
        private readonly IMainPageView _mainPageView;



        public Presenter(IMainPageView mainPageViewRu)
        {
            
            _mainPageView = mainPageViewRu;

            //exit button
            _mainPageView.ExitButtonEntered += () => _mainPageView.MakeExitButtonForeRed();
            _mainPageView.ExitButtonLeavd += () => _mainPageView.MakeExitButtonForeBlack();
            _mainPageView.ExitButtonClick += EXITFUNC;

            // admin buttons
            _mainPageView.AddButtonClick += _mainPageAdminVeiw_AddButtonClick;
            _mainPageView.UPDButtonClick += _mainPageAdminVeiw_UPDButtonClick;
            _mainPageView.DELButtonClick += _mainPageAdminVeiw_DELButtonClick;

            //search and Unsearch
            //_mainPageAdminVeiw.SearchButtonClick+=
            //_mainPageAdminVeiw.ClearSearchButtonClick+=

        
        }

        private void EXITFUNC()
        {
            Application.Exit();
        }
      
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
       
    }
}
