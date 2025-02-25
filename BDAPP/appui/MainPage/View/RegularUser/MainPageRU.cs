using BDAPP.appui.MainPage.Model;
using System.Data;
#pragma warning disable CS0067

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
            Search_Button.Click += Search_Button_Click;

            //appStart
            this.MouseEnter += (s, e) => AppstartMouseEnter?.Invoke();

        }

        private void Search_Button_Click(object? sender, EventArgs e)
        {
            string lastName = LastNameTEXTBOX.Text;
            string firstName = NameTextBox.Text;
            string group = GroupTExtBox.Text;


            if (!string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(group))
            {

                SearchButtonByfamNameGroupClick?.Invoke(new StudentFieldTemplates(lastName, firstName, group));
                return; // Завершаем метод
            }


            MessageBox.Show("Ошибка: необходимо заполнить фамилию и имя и группу.");
        }


        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;


        // seacrh buuton
        public event Action<StudentFieldTemplates>? SearchButtonByIDClick;
        public event Action? ClearSearchButtonClick;
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
            this.DataTableGRIDView.DataSource = students_List;

        }



    }
}
