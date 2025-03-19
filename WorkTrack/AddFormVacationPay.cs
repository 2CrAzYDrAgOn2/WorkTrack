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
                var fullNameVacationPay = textBoxEmployeeIDVacationPay.Text;
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