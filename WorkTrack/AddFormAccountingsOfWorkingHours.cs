using System.Data.SqlClient;

namespace WorkTrack
{
    public partial class AddFormAccountingsOfWorkingHours : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormAccountingsOfWorkingHours()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataBase.OpenConnection();
            comboBoxEmployeeIDAccountingsOfWorkingHours.Items.Clear();
            var employeesQuery = "SELECT FullName FROM Employees ORDER BY FullName";
            var employeesCommand = new SqlCommand(employeesQuery, dataBase.GetConnection());
            var employeesReader = employeesCommand.ExecuteReader();
            while (employeesReader.Read())
            {
                string employeeName = employeesReader.GetString(0);
                comboBoxEmployeeIDAccountingsOfWorkingHours.Items.Add(employeeName);
            }
            employeesReader.Close();
            comboBoxProjectIDAccountingsOfWorkingHours.Items.Clear();
            var projectsQuery2 = "SELECT ProjectName FROM Projects ORDER BY ProjectName";
            var projectsCommand2 = new SqlCommand(projectsQuery2, dataBase.GetConnection());
            var projectsReader2 = projectsCommand2.ExecuteReader();
            while (projectsReader2.Read())
            {
                comboBoxProjectIDAccountingsOfWorkingHours.Items.Add(projectsReader2.GetString(0));
            }
            projectsReader2.Close();
            comboBoxTypeOfRemunerationID.Items.Clear();
            var typesQuery = "SELECT TypeOfRemuneration FROM TypesOfRemuneration ORDER BY TypeOfRemuneration";
            var typesCommand = new SqlCommand(typesQuery, dataBase.GetConnection());
            var typesReader = typesCommand.ExecuteReader();
            while (typesReader.Read())
            {
                comboBoxTypeOfRemunerationID.Items.Add(typesReader.GetString(0));
            }
            typesReader.Close();
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
                var fullNameAccountingsOfWorkingHours = comboBoxEmployeeIDAccountingsOfWorkingHours.Text;
                string queryEmployeeAccountingsOfWorkingHours = $"SELECT EmployeeID FROM Employees WHERE FullName = '{fullNameAccountingsOfWorkingHours}'";
                SqlCommand commandEmployeeAccountingsOfWorkingHours = new(queryEmployeeAccountingsOfWorkingHours, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultEmployeeAccountingsOfWorkingHours = commandEmployeeAccountingsOfWorkingHours.ExecuteScalar();
                var employeeID = resultEmployeeAccountingsOfWorkingHours.ToString();
                var projectNameAccountingsOfWorkingHours = comboBoxProjectIDAccountingsOfWorkingHours.Text;
                string queryProjectAccountingsOfWorkingHours = $"SELECT ProjectID FROM Projects WHERE ProjectName = '{projectNameAccountingsOfWorkingHours}'";
                SqlCommand commandProjectAccountingsOfWorkingHours = new(queryProjectAccountingsOfWorkingHours, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultProjectAccountingsOfWorkingHours = commandProjectAccountingsOfWorkingHours.ExecuteScalar();
                var projectID = resultProjectAccountingsOfWorkingHours.ToString();
                var typeOfRemuneration = comboBoxTypeOfRemunerationID.Text;
                string queryTypeOfRemuneration = $"SELECT TypeOfRemunerationID FROM TypesOfRemuneration WHERE TypeOfRemuneration = '{typeOfRemuneration}'";
                SqlCommand commandTypeOfRemuneration = new(queryTypeOfRemuneration, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultTypeOfRemuneration = commandTypeOfRemuneration.ExecuteScalar();
                var typeOfRemunerationID = resultTypeOfRemuneration.ToString();
                var hoursOfWork = textBoxHoursOfWork.Text;
                var addQuery = $"insert into AccountingsOfWorkingHours (EmployeeID, ProjectID, TypeOfRemunerationID, HoursOfWork) values ('{employeeID}', '{projectID}', '{typeOfRemunerationID}', '{hoursOfWork}')";
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