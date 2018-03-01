namespace WindowsFormsApp1
{
    partial class AllEmployeesSalaryForm
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
            this.AllEmployeesSalaryMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.ChooseDateLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AllEmployeesSalaryActionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllEmployeesSalaryMonthCalendar
            // 
            this.AllEmployeesSalaryMonthCalendar.Location = new System.Drawing.Point(33, 49);
            this.AllEmployeesSalaryMonthCalendar.Name = "AllEmployeesSalaryMonthCalendar";
            this.AllEmployeesSalaryMonthCalendar.TabIndex = 0;
            this.AllEmployeesSalaryMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AllEmployeesSalaryMonthCalendar_DateChanged);
            // 
            // ChooseDateLabel
            // 
            this.ChooseDateLabel.AutoSize = true;
            this.ChooseDateLabel.Location = new System.Drawing.Point(30, 27);
            this.ChooseDateLabel.Name = "ChooseDateLabel";
            this.ChooseDateLabel.Size = new System.Drawing.Size(125, 13);
            this.ChooseDateLabel.TabIndex = 1;
            this.ChooseDateLabel.Text = "Выберите дату расчета";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(209, 49);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultTextBox.TabIndex = 2;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(206, 27);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(59, 13);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Результат";
            // 
            // AllEmployeesSalaryActionButton
            // 
            this.AllEmployeesSalaryActionButton.Location = new System.Drawing.Point(209, 158);
            this.AllEmployeesSalaryActionButton.Name = "AllEmployeesSalaryActionButton";
            this.AllEmployeesSalaryActionButton.Size = new System.Drawing.Size(100, 53);
            this.AllEmployeesSalaryActionButton.TabIndex = 4;
            this.AllEmployeesSalaryActionButton.Text = "Рассчитать";
            this.AllEmployeesSalaryActionButton.UseVisualStyleBackColor = true;
            this.AllEmployeesSalaryActionButton.Click += new System.EventHandler(this.AllEmployeesSalaryActionButton_Click);
            // 
            // AllEmployeesSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 238);
            this.Controls.Add(this.AllEmployeesSalaryActionButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ChooseDateLabel);
            this.Controls.Add(this.AllEmployeesSalaryMonthCalendar);
            this.Name = "AllEmployeesSalaryForm";
            this.Text = "AllEmployeesSalaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar AllEmployeesSalaryMonthCalendar;
        private System.Windows.Forms.Label ChooseDateLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button AllEmployeesSalaryActionButton;
    }
}