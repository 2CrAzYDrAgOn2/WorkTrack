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
                var salaryAccrualID = textBoxSalaryAccrualIDSalary.Text;
                var fullNameSalary = textBoxEmployeeIDSalary.Text;
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