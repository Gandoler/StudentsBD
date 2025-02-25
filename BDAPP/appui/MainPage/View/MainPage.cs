using BDAPP.appui.MainPage.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTSC.MainPage.MainView
{
    public partial class MainPage : Form, IMainPageView
    {


        public MainPage()
        {

            InitializeComponent();

            // Exit button
            ExitButton.Click += (s, e) => ExitButtonClick?.Invoke();
            ExitButton.MouseEnter += (s, e) => ExitButtonEntered?.Invoke();
            ExitButton.MouseLeave += (s, e) => ExitButtonLeavd?.Invoke();

            // Admin buttons 
            Add_Button.Click += (s, e) => btnAdd?.Invoke();
            Delete_Button.Click += (s, e) => btnDelete?.Invoke(this, EventArgs.Empty);
            Update_Button.Click += (s, e) => btnUpdate?.Invoke(DateTable, EventArgs.Empty);
        }

      
        public event EventHandler btnClose;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        public event EventHandler btnProfile;
        public event EventHandler btnAdd;
        public event EventHandler btnClear;
        public event EventHandler btnUpdate;
        public event EventHandler btnDelete;
        public event EventHandler cellStr;


        // Exit button
        public event Action? ExitButtonClick;
        public event Action? ExitButtonEntered;
        public event Action? ExitButtonLeavd;


        public void MakeExitButtonForeBlack()
        {
            ExitButton.ForeColor = Color.Black;
        }

        public void MakeExitButtonForeRed()
        {
            ExitButton.ForeColor = Color.Red;
        }



        //переход на страницу профиля
        public void goToProfile(long id)
        {
            var profileForm = new ProfilePage.ProfileView.ProfilePage();
            var profilePresenter = new ProfilePage.ProfilePresenter.ProfilePresenter(id, profileForm);
            this.Hide();
            profileForm.ShowDialog();
            this.Show();
        }

        //вывод данных в таблицу
        public void SetFriendList(DataTable table)
        {
            DateTable.DataSource = table;
        }


        //Делаем видимость страницы трушной
        public void UpdateVisible()
        {
            txt_interes.Visible = true;
            LastNameTEXTBOX.Visible = true;
            date_picker.Visible = true;
            label_data.Visible = true;
            label_interes.Visible = true;
            LastNamelavel.Visible = true;
            Add_Button.Visible = true;
            Delete_Button.Visible = true;
            Update_Button.Visible = true;
            ClearBtn.Visible = true;
            DateTable.Visible = true;
        }
        //очистка полей
        public void ClearLines()
        {
            txt_interes.Text = string.Empty;
            LastNameTEXTBOX.Text = string.Empty;
            date_picker.Value = DateTime.Now;
        }

      
    }
}
