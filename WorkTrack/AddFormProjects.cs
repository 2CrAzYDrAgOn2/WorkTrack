using System.Data.SqlClient;

namespace WorkTrack
{
    public partial class AddFormProjects : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormProjects()
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
                var projectName = textBoxProjectName.Text;
                var hourly = textBoxHourly.Text;
                var pieceWork = textBoxPieceWork.Text;
                var addQuery = $"insert into Projects (ProjectName, Hourly, PieceWork) values ('{projectName}', '{hourly}', '{pieceWork}')";
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