using BDAPP.logic.DBTools.Managers.CRUD;





namespace BDAPP.appui.MainPage.Model
{
    class MainPageModel: IMainPageModel
    {

        private readonly string _role;
        private readonly ICrudManager _crudManager;

        public MainPageModel(ICrudManager crudManager, string role)
        {
            _crudManager = crudManager;
            _role = role;
        }

        public void AddMark(StudentFieldTemplates studentFieldTemplates)
        {
            _crudManager.AddMark(studentFieldTemplates.Student_id, studentFieldTemplates.Field_Name, studentFieldTemplates.Mark);
        }

        public void UpdateMark(StudentFieldTemplates studentFieldTemplates)
        {
            _crudManager.UpdateMark(studentFieldTemplates.Student_id, studentFieldTemplates.Field_Name, studentFieldTemplates.Mark);
        }

        public void DeleteMark(StudentFieldTemplates studentFieldTemplates)
        {
            _crudManager.DeleteMark(studentFieldTemplates.Student_id, studentFieldTemplates.Field_Name);
        }

        public void search(StudentFieldTemplates studentFieldTemplates)
        {
            _crudManager.Search()
        }


        public void GetFullTable()
        {

        }
    }
}
