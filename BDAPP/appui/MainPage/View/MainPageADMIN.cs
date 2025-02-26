using BDAPP.appui.MainPage.Model;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Management;

namespace BDAPP.appui.MainPage.View.Admin
{
    public partial class MainPageAdmin : Form, IMainPageView
    {


        public MainPageAdmin()
        {

            InitializeComponent();

            // Exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.MouseEnter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.MouseLeave += (s, e) => ExitButtonLeavd?.Invoke();

            // seacrh buuton
            Search_Button.Click += Search_Button_Click;

            // Clear Search
            ClearSearch_button.Click += (s, e) => ClearSearchButtonClick?.Invoke();

            // ADmin buttons
            ADD_button.Click += (s, e) => AddButtonClick?.Invoke(new StudentFieldTemplates(int.Parse(Idtextbox.Text), FieldNameTEXTBOX.Text, int.Parse(Mark_field.Text)));
            UPD_button.Click += (s, e) => UPDButtonClick?.Invoke(new StudentFieldTemplates(int.Parse(Idtextbox.Text), FieldNameTEXTBOX.Text, int.Parse(Mark_field.Text)));

            DEL_button.Click += (s, e) => DELButtonClick?.Invoke(new StudentFieldTemplates(int.Parse(Idtextbox.Text), FieldNameTEXTBOX.Text,1));


            //appStart
            DataTableGRIDView.MouseClick += (s, e) => AppstartMouseEnter?.Invoke();
        }

        private void Search_Button_Click(object? sender, EventArgs e)
        {
            
            if (int.TryParse(Idtextbox.Text, out int studentId) && studentId != 0)
            {
               
                SearchButtonByIDClick?.Invoke(new StudentFieldTemplates(studentId));
                return; 
            }

           
            string lastName = LastNameTEXTBOX.Text;
            string firstName = NameTextBox.Text;

          
            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(firstName))
            {

                SearchButtonByNAMEANDFAMClick?.Invoke(new StudentFieldTemplates(lastName, firstName));
                return; // Завершаем метод
            }

            
            MessageBox.Show("Ошибка: необходимо заполнить либо ID студента, либо фамилию и имя.");
        }




        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;


        // seacrh buuton
        public event Action<StudentFieldTemplates>? SearchButtonByIDClick;


        // clear search 
        public event Action? ClearSearchButtonClick;


        // ADmin buttons
        public event Action<StudentFieldTemplates>? AddButtonClick;
        public event Action<StudentFieldTemplates>? DELButtonClick;
        public event Action<StudentFieldTemplates>? UPDButtonClick;
        public event Action? AppstartMouseEnter;
        public event Action<StudentFieldTemplates>? SearchButtonByNAMEANDFAMClick;
        public event Action<StudentFieldTemplates>? SearchButtonByfamNameGroupClick;

        public void MakeExitButtonForeBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public void MakeExitButtonForeRed()
        {
            ExitButton.ForeColor = Color.Red;
        }

        public void UpdateTable(DataTable students_List)
        {
            DataTableGRIDView.DataSource = students_List;

        }

       public void clear()
        {
            Idtextbox.Clear();
            NameTextBox.Clear();
            LastNameTEXTBOX.Clear();
            FieldNameTEXTBOX.Clear();
            Mark_field.Clear();

        }
    }
}
