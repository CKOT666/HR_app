using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class AllEmployeesSalaryForm : Form
    {
        public AllEmployeesSalaryForm()
        {
            InitializeComponent();
        }

        private void AllEmployeesSalaryMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void AllEmployeesSalaryActionButton_Click(object sender, EventArgs e)
        {
            EmployeeSalary employeeSalary = new EmployeeSalary();
            employeeSalary.FillFields(AllEmployeesSalaryMonthCalendar.SelectionStart);
            ResultTextBox.Text = Convert.ToString(employeeSalary.CountAllEmployeeSalary());
        }
    }
}
