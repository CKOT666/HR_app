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
    public partial class AddEmployeeForm : Form
    {

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_db.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.hR_db.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_db.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.hR_db.Employees);
            GroupСomboBox.SelectedIndex = -1;
            AddEmployeeChiefComboBox.SelectedIndex = -1;
            
        }

        private void AddEmployeeMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void AddEmpolyeeActionButton_Click(object sender, EventArgs e)
        {
            WorkWithDB employeeSalary = new WorkWithDB();

            if (NameTextbox.Text != "")  //проверка на пустое имя нового сотрудника
            {
                if (employeeSalary.GroupId(employeeSalary.EmployeeId(AddEmployeeChiefComboBox.Text)) != 1)  //проверка, чтобы сотрудник группы Employee не мог стать начальником
                {
                    employeeSalary.AddEmployee(Convert.ToString(NameTextbox.Text), StartDateCalendar.SelectionStart, employeeSalary.GroupId(GroupСomboBox.Text), employeeSalary.EmployeeId(AddEmployeeChiefComboBox.Text));
                    MessageBox.Show("Сотрудник добавлен!");
                }
                else
                {
                    employeeSalary.AddEmployee(Convert.ToString(NameTextbox.Text), StartDateCalendar.SelectionStart, employeeSalary.GroupId(GroupСomboBox.Text), employeeSalary.EmployeeId(AddEmployeeChiefComboBox.Text));
                    MessageBox.Show("Сотрудник добавлен без начальника, т.к. сотрудник группы Employees не может быть начальником.");
                }
            }
            else MessageBox.Show("Заполните ФИО сотрудника!");
        }

        private void AddEmployeeChiefComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
