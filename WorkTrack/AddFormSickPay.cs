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
                var FullNameSickPay = textBoxEmployeeIDSickPay.Text;
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
    }
}