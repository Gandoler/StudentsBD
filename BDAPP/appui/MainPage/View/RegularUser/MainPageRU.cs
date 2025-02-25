using BDAPP.appui.MainPage.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDAPP.appui.MainPage.View.RegularUser
{
    public partial class MainPageRU : Form, IMainPageView
    {


        public MainPageRU()
        {

            InitializeComponent();

            // Exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.MouseEnter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.MouseLeave += (s, e) => ExitButtonLeavd?.Invoke();

            // seacrh buuton
            Search_Button.Click += (s, e) => SearchButtonClick?.Invoke(new StudentFieldTemplates(LastNameTEXTBOX.Text,
                                                                                                NameTextBox.Text, GroupTExtBox.Text));
      
            
        }




        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;


        // seacrh buuton
        public event Action<StudentFieldTemplates>? SearchButtonClick;


       

        public void MakeExitButtonForeBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public void MakeExitButtonForeRed()
        {
            ExitButton.ForeColor = Color.Red;
        }

        public void UpdateTable(List<StudentFieldTemplates> students_List)
        {
            foreach (var student in students_List)
            {
                DataTable.Rows.Add(
                    student.Student_id,
                    student.Student_Group_Number,
                    student.Last_Name,
                    student.First_Name,
                    student.Field_Name,
                    student.Mark
                );
            }

        }



    }
}
