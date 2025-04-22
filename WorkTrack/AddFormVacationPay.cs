using System.Data.SqlClient;

namespace WorkTrack
{
    public partial class AddFormVacationPay : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormVacationPay()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxEmployeeIDVacationPay.Items.Clear();
            var employeesQuery = "SELECT FullName FROM Employees ORDER BY FullName";
            var employeesCommand = new SqlCommand(employeesQuery, dataBase.GetConnection());
            var employeesReader = employeesCommand.ExecuteReader();
            while (employeesReader.Read())
            {
                string employeeName = employeesReader.GetString(0);
                comboBoxEmployeeIDVacationPay.Items.Add(employeeName);
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
                var fullNameVacationPay = comboBoxEmployeeIDVacationPay.Text;
                string queryEmployeeVacationPay = $"SELECT EmployeeID FROM Employees WHERE FullName = '{fullNameVacationPay}'";
                SqlCommand commandEmployeeVacationPay = new(queryEmployeeVacationPay, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultEmployeeVacationPay = commandEmployeeVacationPay.ExecuteScalar();
                var employeeID = resultEmployeeVacationPay.ToString();
                var vacationStartDate = dateTimePickerVacationStartDate.Value;
                var vacationEndDate = dateTimePickerVacationEndDate.Value;
                var addQuery = $"insert into VacationPay (EmployeeID, VacationStartDate, VacationEndDate) values ('{employeeID}', '{vacationStartDate}', '{vacationEndDate}')";
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