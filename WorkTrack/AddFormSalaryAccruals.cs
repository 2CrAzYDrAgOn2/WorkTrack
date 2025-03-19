using System.Data.SqlClient;

namespace WorkTrack
{
    public partial class AddFormSalaryAccruals : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormSalaryAccruals()
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
                var year = textBoxYear.Text;
                var month = comboBoxMonthID.Text;
                string queryMonth = $"SELECT MonthID FROM Months WHERE MonthName = '{month}'";
                SqlCommand commandMonth = new(queryMonth, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultMonth = commandMonth.ExecuteScalar();
                var monthID = resultMonth.ToString();
                string projectNameSalaryAccruals = textBoxProjectIDSalaryAccruals.Text;
                string queryProject = $"SELECT ProjectID FROM Projects WHERE ProjectName = '{projectNameSalaryAccruals}'";
                SqlCommand commandProject = new(queryProject, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultProject = commandProject.ExecuteScalar();
                var projectID = resultProject.ToString();
                var addQuery = $"insert into SalaryAccruals (Year, MonthID, ProjectID) values ('{year}', '{monthID}', '{projectID}')";
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