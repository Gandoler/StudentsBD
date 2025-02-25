using BDAPP.appui.MainPage.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.appui.MainPage.View
{
    interface IMainPageViewRu
    {
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;


        // seacrh buuton
        public event Action<StudentFieldTemplates>? SearchButtonClick;



        public void MakeExitButtonForeBlack();
        public void MakeExitButtonForeRed();

        public void UpdateTable(List<StudentFieldTemplates> students_List);
    }
}
