using System.Data.SqlClient;

namespace WorkTrack
{
    public partial class AddFormSickPay : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormSickPay()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxEmployeeIDSickPay.Items.Clear();
            var employeesQuery = "SELECT FullName FROM Employees ORDER BY FullName";
            var employeesCommand = new SqlCommand(employeesQuery, dataBase.GetConnection());
            var employeesReader = employeesCommand.ExecuteReader();
            while (employeesReader.Read())
            {
                string employeeName = employeesReader.GetString(0);
                comboBoxEmployeeIDSickPay.Items.Add(employeeName);
            }
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
                var FullNameSickPay = comboBoxEmployeeIDSickPay.Text;
                string queryEmployeeSickPay = $"SELECT EmployeeID FROM Employees WHERE FullName = '{FullNameSickPay}'";
                SqlCommand commandEmployeeSickPay = new(queryEmployeeSickPay, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultEmployeeSickPay = commandEmployeeSickPay.ExecuteScalar();
                var employeeID = resultEmployeeSickPay.ToString();
                var sickStartDate = dateTimePickerSickStartDate.Value;
                var sickEndDate = dateTimePickerSickEndDate.Value;
                var addQuery = $"insert into SickPay (EmployeeID, SickStartDate, SickEndDate) values ('{employeeID}', '{sickStartDate}', '{sickEndDate}')";
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

        private void dateTimePickerSickEndDate_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}