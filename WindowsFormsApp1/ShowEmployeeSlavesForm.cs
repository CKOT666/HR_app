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
    public partial class ShowEmployeeSlavesForm : Form
    {
        public ShowEmployeeSlavesForm()
        {
            InitializeComponent();
        }

        private void ShowEmployeeSlavesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_db.Employees". При необходимости она может быть перемещена или удалена.
            //this.employeesTableAdapter.Fill(this.hR_db.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_db.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.hR_db.Employees);
            ShowEmployeeSlavesComboBox.SelectedIndex = -1;
           
        }

        private void ShowEmployeeSlavesButton_Click(object sender, EventArgs e)
        {
            
            WorkWithDB workWithDB = new WorkWithDB();
            EmployeeSalary employeeSalary = new EmployeeSalary();
            string[] SlavesArray = (employeeSalary.ShowEmployeeSlaves(ShowEmployeeSlavesComboBox.Text, Convert.ToInt32(workWithDB.QuantityEmployees())));
            int i = 0;
            if (SlavesArray[0] != null)
            {
                while (SlavesArray[i] != null)
                {
                    SlavesComboBox.Items.Add(SlavesArray[i]);
                    i++;
                }
                SlavesComboBox.SelectedIndex = 0;
            }
            else MessageBox.Show("У сотрудника нет подчиненных!");
        }

        private void ShowEmployeeSlavesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SlavesComboBox.SelectedIndex = -1;
            SlavesComboBox.Items.Clear();
        }
    }
}
