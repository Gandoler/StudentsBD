using BDAPP.appui.MainPage.Model;
using BDAPP.appui.MainPage.View;
using BDAPP.appui.MainPage.View.Admin;
using System;
using System.Collections.Generic;
using System.Data;
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
            _mainPageView.SearchButtonByIDClick += _mainPageView_SearchButtonByIDClick; ;
            _mainPageView.SearchButtonByNAMEANDFAMClick += _mainPageView_SearchButtonByNAMEANDFAMClick;
            _mainPageView.SearchButtonByfamNameGroupClick += _mainPageView_SearchButtonByfamNameGroupClick;
            _mainPageView.ClearSearchButtonClick += _mainPageView_ClearSearchButtonClick;

            //inittable 
            _mainPageView.AppstartMouseEnter += _mainPageView_AppstartMouseEnter;

        }

        private void _mainPageView_SearchButtonByfamNameGroupClick(StudentFieldTemplates obj)
        {
            _mainPageView.UpdateTable(_mainPageModel.searchFORCHILD(obj));
        }

        private void _mainPageView_SearchButtonByNAMEANDFAMClick(StudentFieldTemplates obj)
        {
            _mainPageView.UpdateTable(_mainPageModel.searchByNames(obj));
        }

        private void _mainPageView_SearchButtonByIDClick(StudentFieldTemplates obj)
        {
            _mainPageView.UpdateTable(_mainPageModel.searchById(obj));
        }

        private void _mainPageView_AppstartMouseEnter()
        {
            _mainPageView.UpdateTable(_mainPageModel.GetFullTable());
        }

        private void _mainPageView_ClearSearchButtonClick()
        {
            _mainPageView.clear();
            _mainPageView.UpdateTable(_mainPageModel.GetFullTable());
        }

            

      
        private void _mainPageAdminVeiw_DELButtonClick(StudentFieldTemplates obj)
        {
            if (obj == null)
            {
                MessageBox.Show("Ошибка: объект студента не задан.");
                return;
            }

            if (obj.Student_id == 0 || string.IsNullOrEmpty(obj.Field_Name))
            {
                MessageBox.Show("Ошибка: не все обязательные поля заполнены ID и Предмет.");
                return;
            }

            _mainPageModel.DeleteMark(obj);
            _mainPageView.UpdateTable(_mainPageModel.GetFullTable());
        }

        private void _mainPageAdminVeiw_UPDButtonClick(StudentFieldTemplates obj)
        {
            if (obj == null)
            {
                MessageBox.Show("Ошибка: объект студента не задан.");
                return;
            }

            if (obj.Student_id == 0 || string.IsNullOrEmpty(obj.Field_Name) || obj.Mark == 0)
            {
                if (obj.Mark == 0)
                { 
                    MessageBox.Show("Ошибка:Оценка ");
                    return;
                }
                else
                {
                    MessageBox.Show("Ошибка: не все обязательные поля заполнены ID и Предмет.");
                    return;
                }
            }

            _mainPageModel.UpdateMark(obj);
            _mainPageView.UpdateTable(_mainPageModel.GetFullTable());
        }

        private void _mainPageAdminVeiw_AddButtonClick(StudentFieldTemplates obj)
        {
            if (obj == null)
            {
                MessageBox.Show("Ошибка: объект студента не задан.");
                return;
            }

            if (obj.Student_id == 0 || string.IsNullOrEmpty(obj.Field_Name) || obj.Mark == 0)
            {
                MessageBox.Show("Ошибка: не все обязательные поля заполнены ID, Оценка и Предмет.");
                return;
            }

            _mainPageModel.AddMark(obj);
            _mainPageView.UpdateTable(_mainPageModel.GetFullTable());
        }
        private void EXITFUNC()
        {
            Application.Exit();
        }
       
    }
}
