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
            btn_Close.Click += (s, e) => btnClose?.Invoke(this, EventArgs.Empty);
            btn_profile.Click += (s, e) => btnProfile?.Invoke(this, EventArgs.Empty);
            btn_generator.Click += (s, e) => btnToGenerate?.Invoke(this, EventArgs.Empty);
            btn_ezhednevnik.Click += (s, e) => btnToEzhednevnik?.Invoke(this, EventArgs.Empty);
            Add_Button.Click += (s, e) => btnAdd?.Invoke(this, EventArgs.Empty);
            Delete_Button.Click += (s, e) => btnDelete?.Invoke(this, EventArgs.Empty);
            Update_Button.Click += (s, e) => btnUpdate?.Invoke(DateTable, EventArgs.Empty);
            ClearBtn.Click += (s, e) => btnClear?.Invoke(this, EventArgs.Empty);
            DateTable.SelectionChanged += (s, e) => cellStr?.Invoke(DateTable, e);
        }

        public string friendName { get => LastNameTEXTBOX.Text; set => LastNameTEXTBOX.Text = value; }
        public string interested { get => txt_interes.Text; set => txt_interes.Text = value; }
        public DateTime selectedTime { get => date_picker.Value; set => date_picker.Value = value; }

        public event EventHandler btnClose;
        public event EventHandler btnToGenerate;
        public event EventHandler btnToEzhednevnik;
        public event EventHandler btnProfile;
        public event EventHandler btnAdd;
        public event EventHandler btnClear;
        public event EventHandler btnUpdate;
        public event EventHandler btnDelete;
        public event EventHandler cellStr;


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

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
