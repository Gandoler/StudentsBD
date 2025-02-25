using BDAPP.appui.MainPage.Model;
using BDAPP.appui.MainPage.View.RegularUser;
using System.Data;

namespace BDAPP.appui.MainPage.View.Admin
{
    public partial class MainPageAdmin : Form
    {


        public MainPageAdmin()
        {

            InitializeComponent();

            // Exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.MouseEnter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.MouseLeave += (s, e) => ExitButtonLeavd?.Invoke();

            // seacrh buuton
            Search_Button.Click += (s, e) => SearchButtonClick?.Invoke(new StudentFieldTemplates(LastNameTEXTBOX.Text,
                                                                                                NameTextBox.Text, GroupTExtBox.Text));
            MouseEnter += (s, e) => MouseEnterUpdate?.Invoke();

        }




        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;


        // seacrh buuton
        public event Action<StudentFieldTemplates>? SearchButtonClick;


        // for init
        public event Action? MouseEnterUpdate;

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
