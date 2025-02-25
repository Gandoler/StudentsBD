using BDAPP.logic.DBTools.Managers.Connection;
using Microsoft.Data.SqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.logic.DBTools.Managers.CRUD
{
    interface ICrudManager
    {
        public bool UpdateMark(int student_id, string field_Name, int newMark);
        public bool AddMark(int student_id, string field_Name, int mark);
        public bool DeleteMark(int student_id, string field_Name);
        public DataTable Search(int id);
        public DataTable Search(string lastName, string firstName);
        public DataTable Search(int id, string fieldName);
        public DataTable SELECT();
    }
}
