namespace WindowsFormsApp1
{
    partial class AddEmployeeForm
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
            this.components = new System.ComponentModel.Container();
            this.InsertNameLabel = new System.Windows.Forms.Label();
            this.InsertLastnameLabel = new System.Windows.Forms.Label();
            this.ChooseDateLabel = new System.Windows.Forms.Label();
            this.ChooseGroupLabel = new System.Windows.Forms.Label();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.GroupСomboBox = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_db = new WindowsFormsApp1.HR_db();
            this.AddEmpolyeeActionButton = new System.Windows.Forms.Button();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp1.HR_dbTableAdapters.EmployeesTableAdapter();
            this.groupsTableAdapter = new WindowsFormsApp1.HR_dbTableAdapters.GroupsTableAdapter();
            this.AddEmployeeChiefComboBox = new System.Windows.Forms.ComboBox();
            this.StartDateCalendar = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertNameLabel
            // 
            this.InsertNameLabel.AutoSize = true;
            this.InsertNameLabel.Location = new System.Drawing.Point(16, 22);
            this.InsertNameLabel.Name = "InsertNameLabel";
            this.InsertNameLabel.Size = new System.Drawing.Size(140, 13);
            this.InsertNameLabel.TabIndex = 0;
            this.InsertNameLabel.Text = "Введите ФИО сотрудника";
            // 
            // InsertLastnameLabel
            // 
            this.InsertLastnameLabel.AutoSize = true;
            this.InsertLastnameLabel.Location = new System.Drawing.Point(16, 73);
            this.InsertLastnameLabel.Name = "InsertLastnameLabel";
            this.InsertLastnameLabel.Size = new System.Drawing.Size(121, 13);
            this.InsertLastnameLabel.TabIndex = 1;
            this.InsertLastnameLabel.Text = "Выберите Начальника";
            // 
            // ChooseDateLabel
            // 
            this.ChooseDateLabel.AutoSize = true;
            this.ChooseDateLabel.Location = new System.Drawing.Point(173, 22);
            this.ChooseDateLabel.Name = "ChooseDateLabel";
            this.ChooseDateLabel.Size = new System.Drawing.Size(170, 13);
            this.ChooseDateLabel.TabIndex = 2;
            this.ChooseDateLabel.Text = "Выберите дату трудоустройства";
            // 
            // ChooseGroupLabel
            // 
            this.ChooseGroupLabel.AutoSize = true;
            this.ChooseGroupLabel.Location = new System.Drawing.Point(16, 112);
            this.ChooseGroupLabel.Name = "ChooseGroupLabel";
            this.ChooseGroupLabel.Size = new System.Drawing.Size(93, 13);
            this.ChooseGroupLabel.TabIndex = 3;
            this.ChooseGroupLabel.Text = "Выберите группу";
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(19, 50);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(138, 20);
            this.NameTextbox.TabIndex = 4;
            // 
            // GroupСomboBox
            // 
            this.GroupСomboBox.DataSource = this.groupsBindingSource;
            this.GroupСomboBox.DisplayMember = "Name";
            this.GroupСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupСomboBox.FormattingEnabled = true;
            this.GroupСomboBox.Location = new System.Drawing.Point(19, 128);
            this.GroupСomboBox.Name = "GroupСomboBox";
            this.GroupСomboBox.Size = new System.Drawing.Size(138, 21);
            this.GroupСomboBox.TabIndex = 8;
            this.GroupСomboBox.SelectedIndexChanged += new System.EventHandler(this.GroupСomboBox_SelectedIndexChanged);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.hR_db;
            // 
            // hR_db
            // 
            this.hR_db.DataSetName = "HR_db";
            this.hR_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddEmpolyeeActionButton
            // 
            this.AddEmpolyeeActionButton.Location = new System.Drawing.Point(19, 154);
            this.AddEmpolyeeActionButton.Name = "AddEmpolyeeActionButton";
            this.AddEmpolyeeActionButton.Size = new System.Drawing.Size(138, 64);
            this.AddEmpolyeeActionButton.TabIndex = 9;
            this.AddEmpolyeeActionButton.Text = "Добавить сотрудника";
            this.AddEmpolyeeActionButton.UseVisualStyleBackColor = true;
            this.AddEmpolyeeActionButton.Click += new System.EventHandler(this.AddEmpolyeeActionButton_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hR_db;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // AddEmployeeChiefComboBox
            // 
            this.AddEmployeeChiefComboBox.DataSource = this.employeesBindingSource;
            this.AddEmployeeChiefComboBox.DisplayMember = "LName";
            this.AddEmployeeChiefComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddEmployeeChiefComboBox.FormattingEnabled = true;
            this.AddEmployeeChiefComboBox.Location = new System.Drawing.Point(19, 89);
            this.AddEmployeeChiefComboBox.Name = "AddEmployeeChiefComboBox";
            this.AddEmployeeChiefComboBox.Size = new System.Drawing.Size(138, 21);
            this.AddEmployeeChiefComboBox.TabIndex = 11;
            this.AddEmployeeChiefComboBox.SelectedIndexChanged += new System.EventHandler(this.AddEmployeeChiefComboBox_SelectedIndexChanged);
            // 
            // StartDateCalendar
            // 
            this.StartDateCalendar.Location = new System.Drawing.Point(176, 50);
            this.StartDateCalendar.Name = "StartDateCalendar";
            this.StartDateCalendar.TabIndex = 12;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 238);
            this.Controls.Add(this.StartDateCalendar);
            this.Controls.Add(this.AddEmployeeChiefComboBox);
            this.Controls.Add(this.AddEmpolyeeActionButton);
            this.Controls.Add(this.GroupСomboBox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(this.ChooseGroupLabel);
            this.Controls.Add(this.ChooseDateLabel);
            this.Controls.Add(this.InsertLastnameLabel);
            this.Controls.Add(this.InsertNameLabel);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsertNameLabel;
        private System.Windows.Forms.Label InsertLastnameLabel;
        private System.Windows.Forms.Label ChooseDateLabel;
        private System.Windows.Forms.Label ChooseGroupLabel;
        private System.Windows.Forms.TextBox NameTextbox;
        private System.Windows.Forms.ComboBox GroupСomboBox;
        private System.Windows.Forms.Button AddEmpolyeeActionButton;
        private HR_db hR_db;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HR_dbTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private HR_dbTableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.ComboBox AddEmployeeChiefComboBox;
        private System.Windows.Forms.MonthCalendar StartDateCalendar;
    }
}