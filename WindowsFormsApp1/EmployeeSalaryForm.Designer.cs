namespace WindowsFormsApp1
{
    partial class EmployeeSalaryForm
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
            this.ChooseEmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeCombobox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_db = new WindowsFormsApp1.HR_db();
            this.ChooseDateLabel = new System.Windows.Forms.Label();
            this.EmployeeSalaryMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.employeesTableAdapter = new WindowsFormsApp1.HR_dbTableAdapters.EmployeesTableAdapter();
            this.EmployeeSalaryActionButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_db)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseEmployeeLabel
            // 
            this.ChooseEmployeeLabel.AutoSize = true;
            this.ChooseEmployeeLabel.Location = new System.Drawing.Point(12, 21);
            this.ChooseEmployeeLabel.Name = "ChooseEmployeeLabel";
            this.ChooseEmployeeLabel.Size = new System.Drawing.Size(118, 13);
            this.ChooseEmployeeLabel.TabIndex = 0;
            this.ChooseEmployeeLabel.Text = "Выберите сотрудника";
            // 
            // EmployeeCombobox
            // 
            this.EmployeeCombobox.DataSource = this.employeesBindingSource;
            this.EmployeeCombobox.DisplayMember = "LName";
            this.EmployeeCombobox.FormattingEnabled = true;
            this.EmployeeCombobox.Location = new System.Drawing.Point(15, 37);
            this.EmployeeCombobox.Name = "EmployeeCombobox";
            this.EmployeeCombobox.Size = new System.Drawing.Size(164, 21);
            this.EmployeeCombobox.TabIndex = 1;
            this.EmployeeCombobox.ValueMember = "id";
            this.EmployeeCombobox.SelectedIndexChanged += new System.EventHandler(this.EmployeeCombobox_SelectedIndexChanged);
            this.EmployeeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.hR_db;
            // 
            // hR_db
            // 
            this.hR_db.DataSetName = "HR_db";
            this.hR_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChooseDateLabel
            // 
            this.ChooseDateLabel.AutoSize = true;
            this.ChooseDateLabel.Location = new System.Drawing.Point(12, 70);
            this.ChooseDateLabel.Name = "ChooseDateLabel";
            this.ChooseDateLabel.Size = new System.Drawing.Size(177, 13);
            this.ChooseDateLabel.TabIndex = 3;
            this.ChooseDateLabel.Text = "Выберите дату расчета зарплаты";
            // 
            // EmployeeSalaryMonthCalendar
            // 
            this.EmployeeSalaryMonthCalendar.Location = new System.Drawing.Point(15, 83);
            this.EmployeeSalaryMonthCalendar.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.EmployeeSalaryMonthCalendar.Name = "EmployeeSalaryMonthCalendar";
            this.EmployeeSalaryMonthCalendar.TabIndex = 4;
            this.EmployeeSalaryMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EmployeeSalaryMonthCalendar_DateChanged);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeSalaryActionButton
            // 
            this.EmployeeSalaryActionButton.Location = new System.Drawing.Point(210, 181);
            this.EmployeeSalaryActionButton.Name = "EmployeeSalaryActionButton";
            this.EmployeeSalaryActionButton.Size = new System.Drawing.Size(127, 61);
            this.EmployeeSalaryActionButton.TabIndex = 5;
            this.EmployeeSalaryActionButton.Text = "Рассчитать";
            this.EmployeeSalaryActionButton.UseVisualStyleBackColor = true;
            this.EmployeeSalaryActionButton.Click += new System.EventHandler(this.EmployeeSalaryActionButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(207, 21);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(59, 13);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "Результат";
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(210, 38);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(127, 20);
            this.ResultTextbox.TabIndex = 7;
            // 
            // EmployeeSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 254);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.EmployeeSalaryActionButton);
            this.Controls.Add(this.EmployeeSalaryMonthCalendar);
            this.Controls.Add(this.ChooseDateLabel);
            this.Controls.Add(this.EmployeeCombobox);
            this.Controls.Add(this.ChooseEmployeeLabel);
            this.Name = "EmployeeSalaryForm";
            this.Text = "EmployeeSalaryForm";
            this.Load += new System.EventHandler(this.EmployeeSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseEmployeeLabel;
        private System.Windows.Forms.ComboBox EmployeeCombobox;
        private System.Windows.Forms.Label ChooseDateLabel;
        private System.Windows.Forms.MonthCalendar EmployeeSalaryMonthCalendar;
        private HR_db hR_db;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HR_dbTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button EmployeeSalaryActionButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextbox;
    }
}