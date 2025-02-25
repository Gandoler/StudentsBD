namespace OTSC.MainPage.MainView
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            ExitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            npgsqlDataAdapter2 = new Npgsql.NpgsqlDataAdapter();
            mainPanel = new Panel();
            Search_Button = new Guna.UI2.WinForms.Guna2Button();
            GroupTExtBox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            NameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            LastNameTEXTBOX = new Guna.UI2.WinForms.Guna2TextBox();
            LastNamelavel = new Label();
            DateTable = new DataGridView();
            Student_id = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            first_Naem = new DataGridViewTextBoxColumn();
            fieled_name = new DataGridViewTextBoxColumn();
            mark = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DateTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 112, 101);
            panel1.Controls.Add(ExitButton);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 34);
            panel1.TabIndex = 21;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.DisabledState.BorderColor = Color.DarkGray;
            ExitButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ExitButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ExitButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ExitButton.FillColor = Color.Transparent;
            ExitButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(844, 0);
            ExitButton.Margin = new Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ExitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ExitButton.Size = new Size(34, 39);
            ExitButton.TabIndex = 20;
            ExitButton.Text = "X";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(91, 112, 101);
            panel4.Location = new Point(0, 34);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 94);
            panel4.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 33);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 94);
            panel3.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 33);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 386);
            panel2.TabIndex = 22;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(391, 33);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlDataAdapter2
            // 
            npgsqlDataAdapter2.DeleteCommand = null;
            npgsqlDataAdapter2.InsertCommand = null;
            npgsqlDataAdapter2.SelectCommand = null;
            npgsqlDataAdapter2.UpdateCommand = null;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(Search_Button);
            mainPanel.Controls.Add(GroupTExtBox);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(NameTextBox);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(LastNameTEXTBOX);
            mainPanel.Controls.Add(LastNamelavel);
            mainPanel.Controls.Add(DateTable);
            mainPanel.Location = new Point(0, 33);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(877, 386);
            mainPanel.TabIndex = 23;
            // 
            // Search_Button
            // 
            Search_Button.BorderRadius = 15;
            Search_Button.CustomizableEdges = customizableEdges2;
            Search_Button.DisabledState.BorderColor = Color.DarkGray;
            Search_Button.DisabledState.CustomBorderColor = Color.DarkGray;
            Search_Button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Search_Button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Search_Button.FillColor = Color.LightBlue;
            Search_Button.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Search_Button.ForeColor = Color.Black;
            Search_Button.Location = new Point(703, 213);
            Search_Button.Margin = new Padding(3, 2, 3, 2);
            Search_Button.Name = "Search_Button";
            Search_Button.ShadowDecoration.CustomizableEdges = customizableEdges3;
            Search_Button.Size = new Size(153, 46);
            Search_Button.TabIndex = 19;
            Search_Button.Text = "Удалить";
            Search_Button.Visible = false;
            // 
            // GroupTExtBox
            // 
            GroupTExtBox.BorderRadius = 15;
            GroupTExtBox.CustomizableEdges = customizableEdges4;
            GroupTExtBox.DefaultText = "";
            GroupTExtBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            GroupTExtBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            GroupTExtBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            GroupTExtBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            GroupTExtBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            GroupTExtBox.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupTExtBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            GroupTExtBox.Location = new Point(692, 173);
            GroupTExtBox.Margin = new Padding(4, 3, 4, 3);
            GroupTExtBox.Name = "GroupTExtBox";
            GroupTExtBox.PlaceholderText = "";
            GroupTExtBox.SelectedText = "";
            GroupTExtBox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            GroupTExtBox.Size = new Size(181, 35);
            GroupTExtBox.TabIndex = 17;
            GroupTExtBox.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(692, 152);
            label2.Name = "label2";
            label2.Size = new Size(61, 18);
            label2.TabIndex = 16;
            label2.Text = "Группа";
            label2.Visible = false;
            // 
            // NameTextBox
            // 
            NameTextBox.BorderRadius = 15;
            NameTextBox.CustomizableEdges = customizableEdges6;
            NameTextBox.DefaultText = "";
            NameTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            NameTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            NameTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            NameTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            NameTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            NameTextBox.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            NameTextBox.Location = new Point(692, 108);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PlaceholderText = "";
            NameTextBox.SelectedText = "";
            NameTextBox.ShadowDecoration.CustomizableEdges = customizableEdges7;
            NameTextBox.Size = new Size(181, 35);
            NameTextBox.TabIndex = 15;
            NameTextBox.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(692, 87);
            label1.Name = "label1";
            label1.Size = new Size(37, 18);
            label1.TabIndex = 14;
            label1.Text = "имя";
            label1.Visible = false;
            // 
            // LastNameTEXTBOX
            // 
            LastNameTEXTBOX.BorderRadius = 15;
            LastNameTEXTBOX.CustomizableEdges = customizableEdges8;
            LastNameTEXTBOX.DefaultText = "";
            LastNameTEXTBOX.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            LastNameTEXTBOX.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            LastNameTEXTBOX.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            LastNameTEXTBOX.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            LastNameTEXTBOX.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            LastNameTEXTBOX.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LastNameTEXTBOX.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            LastNameTEXTBOX.Location = new Point(692, 46);
            LastNameTEXTBOX.Margin = new Padding(4, 3, 4, 3);
            LastNameTEXTBOX.Name = "LastNameTEXTBOX";
            LastNameTEXTBOX.PlaceholderText = "";
            LastNameTEXTBOX.SelectedText = "";
            LastNameTEXTBOX.ShadowDecoration.CustomizableEdges = customizableEdges9;
            LastNameTEXTBOX.Size = new Size(181, 35);
            LastNameTEXTBOX.TabIndex = 9;
            LastNameTEXTBOX.Visible = false;
            // 
            // LastNamelavel
            // 
            LastNamelavel.AutoSize = true;
            LastNamelavel.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LastNamelavel.Location = new Point(692, 25);
            LastNamelavel.Name = "LastNamelavel";
            LastNamelavel.Size = new Size(78, 18);
            LastNamelavel.TabIndex = 2;
            LastNamelavel.Text = "Фамилия";
            LastNamelavel.Visible = false;
            // 
            // DateTable
            // 
            DateTable.AllowUserToAddRows = false;
            DateTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DateTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DateTable.BackgroundColor = Color.WhiteSmoke;
            DateTable.BorderStyle = BorderStyle.None;
            DateTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DateTable.Columns.AddRange(new DataGridViewColumn[] { Student_id, last_name, first_Naem, fieled_name, mark });
            DateTable.Location = new Point(12, 5);
            DateTable.Margin = new Padding(3, 2, 3, 2);
            DateTable.Name = "DateTable";
            DateTable.RowHeadersVisible = false;
            DateTable.RowHeadersWidth = 51;
            DateTable.Size = new Size(673, 369);
            DateTable.TabIndex = 0;
            DateTable.Visible = false;
            // 
            // Student_id
            // 
            Student_id.HeaderText = "ID";
            Student_id.Name = "Student_id";
            // 
            // last_name
            // 
            last_name.HeaderText = "Фамилия";
            last_name.Name = "last_name";
            // 
            // first_Naem
            // 
            first_Naem.HeaderText = "Имя";
            first_Naem.Name = "first_Naem";
            // 
            // fieled_name
            // 
            fieled_name.HeaderText = "Дисциплина";
            fieled_name.Name = "fieled_name";
            // 
            // mark
            // 
            mark.HeaderText = "оценка";
            mark.Name = "mark";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(877, 418);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DateTable).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter2;
        private Panel mainPanel;
        private DataGridView DateTable;
        private DateTimePicker dateTimePicker1;
        private Label LastNamelavel;
        private Guna.UI2.WinForms.Guna2TextBox LastNameTEXTBOX;
        private Guna.UI2.WinForms.Guna2CircleButton ExitButton;
        private Guna.UI2.WinForms.Guna2TextBox GroupTExtBox;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox NameTextBox;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button Search_Button;
        private DataGridViewTextBoxColumn Student_id;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn first_Naem;
        private DataGridViewTextBoxColumn fieled_name;
        private DataGridViewTextBoxColumn mark;
    }
}