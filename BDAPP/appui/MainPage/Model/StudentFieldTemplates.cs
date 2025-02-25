using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDAPP.appui.MainPage.Model
{
    public sealed class StudentFieldTemplates
    {
        private int _student_id;
        private string _last_Name = string.Empty;
        private string _first_Name = string.Empty;
        private string _field_Name = string.Empty;
        private string _student_Group_Number = string.Empty;
        private int _mark;

        // for db init
     public StudentFieldTemplates(int student_id, string last_Name, string first_Name, string field_Name, int mark, string student_Group_Number)
        {
            _student_id = student_id;
            _last_Name = last_Name;
            _first_Name = first_Name;
            _field_Name = field_Name;
            _mark = mark;
            _student_Group_Number = student_Group_Number;
        }
        // fast search
        public StudentFieldTemplates(int student_id)
        {
            _student_id = student_id;

        }
        // base search
        public StudentFieldTemplates(string last_Name, string first_Name, string student_Group_Number)
        {
            _last_Name = last_Name;
            _first_Name = first_Name;
            _student_Group_Number = student_Group_Number;
        }

        // crud
        public StudentFieldTemplates(int student_id, string field_Name, int mark)
        {
            _student_id = student_id;
            _field_Name = field_Name;
            _mark = Mark;
        }

        public int Student_id { get => _student_id;  }
        public string Last_Name { get => _last_Name; }
        public string First_Name { get => _first_Name; }
        public string Field_Name { get => _field_Name;   }
        public int Mark { get => _mark;  }
        public string Student_Group_Number { get => _student_Group_Number;}
    }
   
    }
