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
    class PresenterMain
    {

        
        private readonly IMainPageView _mainPageView;
        private readonly IMainPageModel _mainPageModel;


        public PresenterMain(IMainPageView mainPageViewRu, IMainPageModel mainPageModel)
        {
            _mainPageModel = mainPageModel;
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
            _mainPageView.SearchButtonClick += _mainPageView_SearchButtonClick;
            _mainPageView.ClearSearchButtonClick += _mainPageView_ClearSearchButtonClick;

            //inittable 
            _mainPageView.AppstartMouseEnter += _mainPageView_AppstartMouseEnter;

        }

        private void _mainPageView_AppstartMouseEnter()
        {
            _mainPageView.UpdateTable(_mainPageModel.GetFullTable());
        }

        private void _mainPageView_ClearSearchButtonClick()
        {
            throw new NotImplementedException();
        }

        private void _mainPageView_SearchButtonClick(StudentFieldTemplates obj)
        {
            throw new NotImplementedException();
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
        private void EXITFUNC()
        {
            Application.Exit();
        }
       
    }
}
