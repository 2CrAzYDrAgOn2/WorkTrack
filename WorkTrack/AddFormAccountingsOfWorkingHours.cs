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
                var fullNameAccountingsOfWorkingHours = textBoxEmployeeIDAccountingsOfWorkingHours.Text;
                string queryEmployeeAccountingsOfWorkingHours = $"SELECT EmployeeID FROM Employees WHERE FullName = '{fullNameAccountingsOfWorkingHours}'";
                SqlCommand commandEmployeeAccountingsOfWorkingHours = new(queryEmployeeAccountingsOfWorkingHours, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultEmployeeAccountingsOfWorkingHours = commandEmployeeAccountingsOfWorkingHours.ExecuteScalar();
                var employeeID = resultEmployeeAccountingsOfWorkingHours.ToString();
                var projectNameAccountingsOfWorkingHours = textBoxProjectIDAccountingsOfWorkingHours.Text;
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