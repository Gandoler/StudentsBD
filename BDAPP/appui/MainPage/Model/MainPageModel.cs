using BDAPP.logic.DBTools.Managers.Connection;
using BDAPP.logic.DBTools.Managers.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


//CREATE OR REPLACE FUNCTION FIELDID_BY_Name(filedNameInput varchar(100))
//RETURNS uuid
//LANGUAGE plpgsql
//AS $$
//DECLARE 
//    FIELDID uuid;
//BEGIN
//    SELECT field_id INTO FIELDID
//    FROM fields
//    WHERE fields.field_name = filedNameInput;

//IF NOT FOUND THEN
//        RETURN NULL;
//END IF;

//RETURN FIELDID;
//END;
//$$;


namespace BDAPP.appui.MainPage.Model
{
    class MainPageModel: IMainPageModel
    {

        private readonly string _role;
        private readonly IDataManager _dataManager;

        public MainPageModel(IDataManager dataManager, string role)
        {
            _dataManager = dataManager;
            _role = role;
        }

        public void AddMark(StudentFieldTemplates studentFieldTemplates)
        {
            if (_role != "admin")
            {
                throw new UnauthorizedAccessException("Недостаточно прав.");
            }

            string query = "" +
                "" +
                "" +
                "INSERT INTO field_comprehensions (student_id, field, mark) VALUES (@studentId, @field, @mark)";

            var parameters = new[]
            {
            new SqlParameter("@studentId", SqlDbType.Int) { Value = studentFieldTemplates.Student_id },
            new SqlParameter("@field", SqlDbType.UniqueIdentifier) { Value = studentFieldTemplates.Field_Name },
            new SqlParameter("@mark", SqlDbType.Int) { Value = studentFieldTemplates.Mark }
        };

            _dataManager.ExecuteQuery(query, parameters);
        }

        public void UpdateMark(StudentFieldTemplates studentFieldTemplates)
        {

        }

        public void DeleteMark(StudentFieldTemplates studentFieldTemplates)
        {

        }

        public void search(StudentFieldTemplates studentFieldTemplates)
        {

        }


        public void GetFullTable()
        {

        }
    }
}
