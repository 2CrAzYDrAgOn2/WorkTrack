using System.Data.SqlClient;

namespace WorkTrack
{
    public partial class AddFormEmployees : Form
    {
        private readonly DataBase dataBase = new();

        public AddFormEmployees()
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
                var fullName = textBoxFullName.Text;
                var birthDate = dateTimePickerBirthDate.Value;
                var birthPlace = textBoxBirthPlace.Text;
                var passportSeries = textBoxPassportSeries.Text;
                var passportNumber = textBoxPassportNumber.Text;
                var phone = maskedTextBoxPhone.Text;
                var email = textBoxEmail.Text;
                var iNN = textBoxINN.Text;
                var post = comboBoxPostID.Text;
                string queryPost = $"SELECT PostID FROM Posts WHERE Post = '{post}'";
                SqlCommand commandPost = new(queryPost, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultPost = commandPost.ExecuteScalar();
                var postID = resultPost.ToString();
                var gender = comboBoxGenderID.Text;
                string queryGender = $"SELECT GenderID FROM Genders WHERE Gender = '{gender}'";
                SqlCommand commandGender = new(queryGender, dataBase.GetConnection());
                dataBase.OpenConnection();
                object resultGender = commandGender.ExecuteScalar();
                var genderID = resultGender.ToString();
                var addQuery = $"insert into Employees (FullName, BirthDate, BirthPlace, PassportSeries, PassportNumber, Phone, Email, INN, PostID, GenderID) values ('{fullName}', '{birthDate}', '{birthPlace}', '{passportSeries}', '{passportNumber}', '{phone}', '{email}', '{iNN}', '{postID}', '{genderID}')";
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