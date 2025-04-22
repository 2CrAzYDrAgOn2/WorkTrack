using System.Data.SqlClient;

namespace WorkTrack
{
    public partial class AddFormSalary : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormSalary()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxSalaryAccrualIDSalary.Items.Clear();
            var salaryAccrualsQuery = "SELECT SalaryAccrualID FROM SalaryAccruals ORDER BY SalaryAccrualID";
            var salaryAccrualsCommand = new SqlCommand(salaryAccrualsQuery, dataBase.GetConnection());
            var salaryAccrualsReader = salaryAccrualsCommand.ExecuteReader();
            while (salaryAccrualsReader.Read())
            {
                comboBoxSalaryAccrualIDSalary.Items.Add(salaryAccrualsReader.GetInt32(0));
            }
            salaryAccrualsReader.Close();
            comboBoxEmployeeIDSalary.Items.Clear();
            var employeesQuery = "SELECT FullName FROM Employees ORDER BY FullName";
            var employeesCommand = new SqlCommand(employeesQuery, dataBase.GetConnection());
            var employeesReader = employeesCommand.ExecuteReader();
            while (employeesReader.Read())
            {
                string employeeName = employeesReader.GetString(0);
                comboBoxEmployeeIDSalary.Items.Add(employeeName);
            }
            employeesReader.Close();
        }

        /// <summary>
        /// ButtonSave_Click() вызывается при нажатии на кнопку "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.OpenConnection();
                var salaryAccrualID = comboBoxSalaryAccrualIDSalary.Text;
                var fullNameSalary = comboBoxEmployeeIDSalary.Text;
                string queryEmployee = $"SELECT EmployeeID FROM Employees WHERE FullName = '{fullNameSalary}'";
                SqlCommand commandEmployee = new(queryEmployee, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultEmployee = commandEmployee.ExecuteScalar();
                var employeeID = resultEmployee.ToString();
                var addQuery = $"insert into Salary (SalaryAccrualID, EmployeeID) values ('{salaryAccrualID}', '{employeeID}')";
                var sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataBase.CloseConnection();
            }
        }
    }
}