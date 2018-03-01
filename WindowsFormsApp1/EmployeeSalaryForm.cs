using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.SQLite;

namespace WindowsFormsApp1
{
    public class EmployeeSalary
    {
        WorkWithDB workWithDB = new WorkWithDB(); 
        private int yearsOfWork;
        private int employeeId;
        private double bonusPerYear;
        private double baseSalary;

        private double EmployeesGroupSalaryCount()  //РАсчет ЗП для сотрудника группы Employee
        {
            if (bonusPerYear*yearsOfWork <= 0.3)
            return Convert.ToDouble(yearsOfWork * baseSalary * bonusPerYear + baseSalary);
            else return Convert.ToDouble(0.3 * baseSalary + baseSalary);
        }
        private double ManagersGroupSalaryCount() // Расчет ЗП для сотрудника группы Managers
        {
            if (bonusPerYear * yearsOfWork <= 0.4)
            return Convert.ToDouble(baseSalary * bonusPerYear * yearsOfWork + baseSalary + ((0.005) * workWithDB.CountEmployees(employeeId, 1) * workWithDB.GroupsBaseSalary(1)));
            else return Convert.ToDouble(baseSalary * 0.4 + baseSalary + ((0.005) * workWithDB.CountEmployees(employeeId, 1) * workWithDB.GroupsBaseSalary(1)));

        }
        private double SalesmansGroupSalaryCount() // Расчет ЗП для сотрудника группы Salesmans
        {
            if (bonusPerYear * yearsOfWork <= 0.35)
            return Convert.ToDouble(baseSalary * bonusPerYear * yearsOfWork + baseSalary + (0.003 * workWithDB.CountEmployees(employeeId, 1) * workWithDB.GroupsBaseSalary(1)) + (0.003 * workWithDB.CountEmployees(employeeId, 2) * workWithDB.GroupsBaseSalary(2)));
            else return Convert.ToDouble(baseSalary * 0.35 + baseSalary + (0.003 * workWithDB.CountEmployees(employeeId, 1) * workWithDB.GroupsBaseSalary(1)) + (0.003 * workWithDB.CountEmployees(employeeId, 2) * workWithDB.GroupsBaseSalary(2)));

        }

        public double EmployeeSalaryCount()  //Расчет ЗП в зависимости от группы сотрудника
        {
            int idGroup = workWithDB.GroupId(employeeId);
            if (idGroup == 1)
                return Convert.ToDouble(EmployeesGroupSalaryCount());
            else if (idGroup == 2)
                return Convert.ToDouble(ManagersGroupSalaryCount());
            else return Convert.ToDouble(SalesmansGroupSalaryCount());

        }

        public double EmployeeSalaryCount(int id)  //Перегрузка метода EmployeeSalaryCount - Расчет ЗП в зависимости от группы сотрудника
        {
            int idGroup = workWithDB.GroupId(id);
            if (idGroup == 1)
                return Convert.ToDouble(EmployeesGroupSalaryCount());
            else if (idGroup == 2)
                return Convert.ToDouble(ManagersGroupSalaryCount());
            else return Convert.ToDouble(SalesmansGroupSalaryCount());

        }

        public void FillFields(string ChosenEmployee, DateTime ChosenDate) 
        {
            employeeId = workWithDB.EmployeeId(ChosenEmployee);
            yearsOfWork = workWithDB.CountYearsOfWork(employeeId, ChosenDate);
            bonusPerYear = workWithDB.SelectBonusPerYearForGroup(employeeId);
            baseSalary = workWithDB.SelectChosenEmployeeBaseSalary(employeeId);
        } //Заполнение полей класса EmployeeSalary

        public void FillFields(DateTime ChosenDate)
        {
            employeeId = 1;
            yearsOfWork = workWithDB.CountYearsOfWork(employeeId, ChosenDate);
            bonusPerYear = workWithDB.SelectBonusPerYearForGroup(employeeId);
            baseSalary = workWithDB.SelectChosenEmployeeBaseSalary(employeeId);
        }  // Перегрузка метода FillFields - Заполнение полей класса EmployeeSalary

        public double CountAllEmployeeSalary() //Расчет ЗП всех сотрудников
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select id from employees";
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            double Sum = 0;
            while (reader.Read())
            {
                Sum += EmployeeSalaryCount(reader.GetInt32(0));
            }
            return Sum;
        }

        public string[] ShowEmployeeSlaves (string EmployeeName, int ArrayLength)  //Метод показывает подчиненых сотрудника
        {
            
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "select LName from employees where idChief = " + workWithDB.EmployeeId(EmployeeName);

            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            string[] EmployeesName = new string[ArrayLength];
            int i = 0;
            while (reader.Read())
            {
                EmployeesName[i] = (reader.GetString(0));
                i++;
            }
            reader.Close();
            connection.Close();
            return EmployeesName;
        }
        
    }  //Класс для расчета ЗП и отображения подчиненных сотрудника

    public class WorkWithDB
    {

        public int EmployeeId(string Lname) // Определение Id сотрудника по имени
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select id from employees where LName = '" + Lname + "'";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            int ChosenEmployeeId = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();
            return ChosenEmployeeId;

        }

        public int GroupId(int ChosenEmployeeId) // Определение Id группы по id сотрудника
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select idgroup from employees where id = " + ChosenEmployeeId;
            SQLiteCommand command = new SQLiteCommand(query, connection);

            int GroupId = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();
            return GroupId;

        }
        public int GroupId(string GroupName)  //Перегрузка методв GroupId - Определение idGroup по имени группы
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select id from groups where Name = '" + GroupName + "'";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            int GroupId = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();
            return GroupId;

        }

        public int CountYearsOfWork(int ChosenEmployeeId, DateTime ChosenSalaryDate) // Расчет стажа работы сотрудника
        {

            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select StartDate from employees where Id = " + ChosenEmployeeId;
            SQLiteCommand command = new SQLiteCommand(query, connection);

            DateTime StartDate = new DateTime();

            StartDate = Convert.ToDateTime(command.ExecuteScalar());
            connection.Close();
            return Convert.ToInt32((ChosenSalaryDate.Subtract(StartDate)).Days / 365);
        }
        public double SelectBonusPerYearForGroup(int ChosenEmployeeId)  //Выбор бонуса за год стажа в зависимости от группы сотрудника
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "select g.BonusPerYear from employees e "
                + "join Groups g "
                + "on e.idgroup = g.id "
                + "where e.id = " + ChosenEmployeeId;
            SQLiteCommand command = new SQLiteCommand(query, connection);
            double BonusPerYear = Convert.ToDouble(command.ExecuteScalar());
            connection.Close();
            return BonusPerYear;
        }  //

        public double SelectChosenEmployeeBaseSalary(int ChosenEmployeeId)
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "select g.BaseSalary from employees e "
                + "join Groups g "
                + "on e.idgroup = g.id "
                + "where e.id = " + ChosenEmployeeId;
            SQLiteCommand command = new SQLiteCommand(query, connection);

            double BaseSalary = Convert.ToDouble(command.ExecuteScalar());

            connection.Close();
            return BaseSalary;
        }  //Выбор базовой ЗП сотрудника в зависимости от группы
        public int CountEmployees(int ChosenEmployeeId, int IdGroup)
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select count(id) from employees where idChief = " + ChosenEmployeeId + " and IdGroup = " + IdGroup;
            SQLiteCommand command = new SQLiteCommand(query, connection);

            int CountSlaves = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();
            return CountSlaves;
        }  //Считаем количество подчиненных сотрудника конкретной группы
        public int QuantityEmployees()
        {


            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select count(id) from employees";
            SQLiteCommand command = new SQLiteCommand(query, connection);

            int QuantityEmployees = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();
            return QuantityEmployees;

        }  //Считаем общее количество сотрудников
        public double GroupsBaseSalary(int idGroup)
        {
            string connectionString = "Data Source=HR.db; Version=3;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);

            connection.Open();

            string query = "Select BaseSalary from Groups where id = " + idGroup;
            SQLiteCommand command = new SQLiteCommand(query, connection);

            int BaseSalary = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();
            return BaseSalary;
        }  //Выбор базовой ЗП в зависимости от группы
        public void AddEmployee(string Name, DateTime StartDate, int IdGroup, int IdChief)
        {
                string connectionString = "Data Source=HR.db; Version=3;";
                SQLiteConnection connection = new SQLiteConnection(connectionString);

                connection.Open();

                string query = "INSERT INTO Employees (LName, StartDate, idGroup, idChief) VALUES ('" + Name + "', '" + StartDate + "', " + IdGroup + ", " + IdChief + ");";

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            } //Добавляем сотрудника
    } // Класс для работы с БД


    public partial class EmployeeSalaryForm : Form
    {


        public EmployeeSalaryForm()
        {
            InitializeComponent();
            
        }

        private void EmployeeSalaryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hR_db.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.hR_db.Employees);
            EmployeeCombobox.SelectedIndex = -1;           
        }

        public void EmployeeSalaryActionButton_Click(object sender, EventArgs e)
        {
            ResultTextbox.Clear();

            EmployeeSalary employeeSalary = new EmployeeSalary();
            employeeSalary.FillFields(EmployeeCombobox.Text.ToString(), EmployeeSalaryMonthCalendar.SelectionStart);
            ResultTextbox.Text = Convert.ToString(employeeSalary.EmployeeSalaryCount());
        }

        private void EmployeeSalaryMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {       
            
        }

        private void EmployeeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
                                
        }
    }
}
