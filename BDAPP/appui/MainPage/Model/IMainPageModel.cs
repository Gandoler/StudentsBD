using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.appui.MainPage.Model
{
    interface IMainPageModel
    {
        public void AddMark(StudentFieldTemplates studentFieldTemplates);

        public void UpdateMark(StudentFieldTemplates studentFieldTemplates);

        public void DeleteMark(StudentFieldTemplates studentFieldTemplates);

        public DataTable searchById(StudentFieldTemplates studentFieldTemplates);

        public DataTable searchByNames(StudentFieldTemplates studentFieldTemplates);

        public DataTable searchByFieldAndID(StudentFieldTemplates studentFieldTemplates);


        public DataTable GetFullTable();
    }
}
