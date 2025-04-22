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
            dataBase.OpenConnection();
            comboBoxMonthID.Items.Clear();
            var monthsQuery = "SELECT MonthName FROM Months ORDER BY MonthName";
            var monthsCommand = new SqlCommand(monthsQuery, dataBase.GetConnection());
            var monthsReader = monthsCommand.ExecuteReader();
            while (monthsReader.Read())
            {
                comboBoxMonthID.Items.Add(monthsReader.GetString(0));
            }
            monthsReader.Close();
            comboBoxProjectIDSalaryAccruals.Items.Clear();
            var projectsQuery = "SELECT ProjectName FROM Projects ORDER BY ProjectName";
            var projectsCommand = new SqlCommand(projectsQuery, dataBase.GetConnection());
            var projectsReader = projectsCommand.ExecuteReader();
            while (projectsReader.Read())
            {
                comboBoxProjectIDSalaryAccruals.Items.Add(projectsReader.GetString(0));
            }
            projectsReader.Close();
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
                string projectNameSalaryAccruals = comboBoxProjectIDSalaryAccruals.Text;
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