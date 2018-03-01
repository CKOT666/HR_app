namespace WindowsFormsApp1
{
    partial class HRMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeSalaryButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.AllEmployeesSalaryButton = new System.Windows.Forms.Button();
            this.ShowEmployeeSlavesButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeSalaryButton
            // 
            this.EmployeeSalaryButton.Location = new System.Drawing.Point(22, 45);
            this.EmployeeSalaryButton.Name = "EmployeeSalaryButton";
            this.EmployeeSalaryButton.Size = new System.Drawing.Size(106, 57);
            this.EmployeeSalaryButton.TabIndex = 0;
            this.EmployeeSalaryButton.Text = "Посчитать зарплату сотрудника ";
            this.EmployeeSalaryButton.UseVisualStyleBackColor = true;
            this.EmployeeSalaryButton.Click += new System.EventHandler(this.EmployeeSalaryButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(22, 108);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(106, 61);
            this.AddEmployeeButton.TabIndex = 1;
            this.AddEmployeeButton.Text = "Добавить сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // AllEmployeesSalaryButton
            // 
            this.AllEmployeesSalaryButton.Location = new System.Drawing.Point(157, 45);
            this.AllEmployeesSalaryButton.Name = "AllEmployeesSalaryButton";
            this.AllEmployeesSalaryButton.Size = new System.Drawing.Size(106, 57);
            this.AllEmployeesSalaryButton.TabIndex = 2;
            this.AllEmployeesSalaryButton.Text = "Посчитать зарплату всех сотрудников";
            this.AllEmployeesSalaryButton.UseVisualStyleBackColor = true;
            this.AllEmployeesSalaryButton.Click += new System.EventHandler(this.AllEmployeesSalaryButton_Click);
            // 
            // ShowEmployeeSlavesButton
            // 
            this.ShowEmployeeSlavesButton.Location = new System.Drawing.Point(157, 108);
            this.ShowEmployeeSlavesButton.Name = "ShowEmployeeSlavesButton";
            this.ShowEmployeeSlavesButton.Size = new System.Drawing.Size(106, 61);
            this.ShowEmployeeSlavesButton.TabIndex = 3;
            this.ShowEmployeeSlavesButton.Text = "Посмотреть подчиненных сотрудника";
            this.ShowEmployeeSlavesButton.UseVisualStyleBackColor = true;
            this.ShowEmployeeSlavesButton.Click += new System.EventHandler(this.ShowEmployeeSlavesButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(80, 20);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(130, 13);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Что Вы хотите сделать?";
            // 
            // HRMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 195);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ShowEmployeeSlavesButton);
            this.Controls.Add(this.AllEmployeesSalaryButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.EmployeeSalaryButton);
            this.Name = "HRMainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.HRMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeeSalaryButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button AllEmployeesSalaryButton;
        private System.Windows.Forms.Button ShowEmployeeSlavesButton;
        private System.Windows.Forms.Label QuestionLabel;
    }
}

