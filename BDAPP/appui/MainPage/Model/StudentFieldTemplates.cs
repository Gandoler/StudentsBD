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
        private int _mark;


     public StudentFieldTemplates(int student_id, string last_Name, string first_Name, string field_Name, int mark)
        {
            _student_id = student_id;
            _last_Name = last_Name;
            _first_Name = first_Name;
            _field_Name = field_Name;
            _mark = mark;
        }

        public int Student_id { get => _student_id;  }
        public string Last_Name { get => _last_Name; }
        public string First_Name { get => _first_Name; }
        public string Field_Name { get => _field_Name;   }
        public int Mark { get => _mark;  }
    }
}
