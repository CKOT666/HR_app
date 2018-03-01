using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1


{
    public partial class HRMainForm : Form
    {
        public HRMainForm()
        {
            InitializeComponent();
        }

        private void EmployeeSalaryButton_Click(object sender, EventArgs e)
        {
            EmployeeSalaryForm employeeSalaryForm = new EmployeeSalaryForm();
            employeeSalaryForm.Show();
        }

        private void AllEmployeesSalaryButton_Click(object sender, EventArgs e)
        {
            AllEmployeesSalaryForm allEmployeesSalaryForm = new AllEmployeesSalaryForm();
            allEmployeesSalaryForm.Show();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void ShowEmployeeSlavesButton_Click(object sender, EventArgs e)
        {
            ShowEmployeeSlavesForm showEmployeeSlaves = new ShowEmployeeSlavesForm();
            showEmployeeSlaves.Show();
        }

        private void HRMainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
