using BDAPP.appui.Login.Model;
using BDAPP.logic;
using BDAPP.logic.DBTools.Managers.CRUD;
using Serilog;
using System.Data;





namespace BDAPP.appui.MainPage.Model
{
    class MainPageModel: IMainPageModel
    {

        private readonly User _bduser;
        private readonly ICrudManager _crudManager;

        public MainPageModel(ICrudManager crudManager, User bduser)
        {
            _crudManager = crudManager;
            _bduser = bduser;
        }

        public void AddMark(StudentFieldTemplates studentFieldTemplates)
        {
            if (_bduser.Role == "junior")
            {
                Log.Information("junchik попытался взять данные");
                return;
            }
            _crudManager.AddMark(studentFieldTemplates.Student_id, studentFieldTemplates.Field_Name, studentFieldTemplates.Mark);
        }

        public void UpdateMark(StudentFieldTemplates studentFieldTemplates)
        {
            if (_bduser.Role == "junior")
            {
                Log.Information("junchik попытался взять данные");
                return;
            }
            _crudManager.UpdateMark(studentFieldTemplates.Student_id, studentFieldTemplates.Field_Name, studentFieldTemplates.Mark);
        }

        public void DeleteMark(StudentFieldTemplates studentFieldTemplates)
        {
            if (_bduser.Role == "junior")
            {
                Log.Information("junchik попытался взять данные");
                return;
            }
            _crudManager.DeleteMark(studentFieldTemplates.Student_id, studentFieldTemplates.Field_Name);
        }

        public DataTable searchById(StudentFieldTemplates studentFieldTemplates)
        {
            return _crudManager.Search(studentFieldTemplates.Student_id);
        }

        public DataTable searchByNames(StudentFieldTemplates studentFieldTemplates)
        {
            return _crudManager.Search(studentFieldTemplates.Last_Name, studentFieldTemplates.First_Name);
        }

        public DataTable searchByFieldAndID(StudentFieldTemplates studentFieldTemplates)
        {
            return _crudManager.Search(studentFieldTemplates.Student_id, studentFieldTemplates.Field_Name);
        }


        public DataTable searchFORCHILD(StudentFieldTemplates studentFieldTemplates)
        {
            return _crudManager.Search(studentFieldTemplates.Last_Name, studentFieldTemplates.First_Name, studentFieldTemplates.Student_Group_Number);
        }


        public DataTable GetFullTable()
        {
            return _crudManager.SELECT();
        }
    }
}
