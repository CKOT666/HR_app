namespace WindowsFormsApp1
{
    partial class ShowEmployeeSlavesForm
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
            this.ShowEmployeeSlavesButton = new System.Windows.Forms.Button();
            this.ShowEmployeeSlavesComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hR_db = new WindowsFormsApp1.HR_db();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesTableAdapter = new WindowsFormsApp1.HR_dbTableAdapters.EmployeesTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.SlavesComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_db)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowEmployeeSlavesButton
            // 
            this.ShowEmployeeSlavesButton.Location = new System.Drawing.Point(12, 93);
            this.ShowEmployeeSlavesButton.Name = "ShowEmployeeSlavesButton";
            this.ShowEmployeeSlavesButton.Size = new System.Drawing.Size(121, 49);
            this.ShowEmployeeSlavesButton.TabIndex = 0;
            this.ShowEmployeeSlavesButton.Text = "Показать подчиненных";
            this.ShowEmployeeSlavesButton.UseVisualStyleBackColor = true;
            this.ShowEmployeeSlavesButton.Click += new System.EventHandler(this.ShowEmployeeSlavesButton_Click);
            // 
            // ShowEmployeeSlavesComboBox
            // 
            this.ShowEmployeeSlavesComboBox.DataSource = this.employeesBindingSource;
            this.ShowEmployeeSlavesComboBox.DisplayMember = "LName";
            this.ShowEmployeeSlavesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowEmployeeSlavesComboBox.FormattingEnabled = true;
            this.ShowEmployeeSlavesComboBox.Location = new System.Drawing.Point(12, 25);
            this.ShowEmployeeSlavesComboBox.Name = "ShowEmployeeSlavesComboBox";
            this.ShowEmployeeSlavesComboBox.Size = new System.Drawing.Size(121, 21);
            this.ShowEmployeeSlavesComboBox.TabIndex = 1;
            this.ShowEmployeeSlavesComboBox.SelectedIndexChanged += new System.EventHandler(this.ShowEmployeeSlavesComboBox_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите сотрудника";
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подчиненные:";
            // 
            // SlavesComboBox
            // 
            this.SlavesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SlavesComboBox.FormattingEnabled = true;
            this.SlavesComboBox.Location = new System.Drawing.Point(186, 25);
            this.SlavesComboBox.Name = "SlavesComboBox";
            this.SlavesComboBox.Size = new System.Drawing.Size(156, 21);
            this.SlavesComboBox.TabIndex = 4;
            // 
            // ShowEmployeeSlavesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 154);
            this.Controls.Add(this.SlavesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowEmployeeSlavesComboBox);
            this.Controls.Add(this.ShowEmployeeSlavesButton);
            this.Name = "ShowEmployeeSlavesForm";
            this.Text = "ShowEmployeeSlavesForm";
            this.Load += new System.EventHandler(this.ShowEmployeeSlavesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hR_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowEmployeeSlavesButton;
        private System.Windows.Forms.ComboBox ShowEmployeeSlavesComboBox;
        private System.Windows.Forms.Label label1;
        private HR_db hR_db;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private HR_dbTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SlavesComboBox;
    }
}