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
            Search_Button.Click += (s, e) => SearchButtonClick?.Invoke(new StudentFieldTemplates(LastNameTEXTBOX.Text,
                                                                                                NameTextBox.Text, GroupTExtBox.Text));

            //appStart
            this.MouseEnter += (s, e) => AppstartMouseEnter?.Invoke();

        }




        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;


        // seacrh buuton
        public event Action<StudentFieldTemplates>? SearchButtonClick;
        public event Action? ClearSearchButtonClick;
        public event Action<StudentFieldTemplates>? AddButtonClick;
        public event Action<StudentFieldTemplates>? DELButtonClick;
        public event Action<StudentFieldTemplates>? UPDButtonClick;
        public event Action? AppstartMouseEnter;
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
            this.DataTable.DataSource = students_List;

        }



    }
}
