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
                //dataBase.OpenConnection();
                //var userLogin = textBoxRegistrationIDLoans.Text;
                //string query = $"SELECT RegistrationID FROM Registration WHERE UserLogin = '{userLogin}'";
                //SqlCommand command = new(query, dataBase.GetConnection());
                //dataBase.OpenConnection();
                //object result = command.ExecuteScalar();
                //var registrationID = result.ToString();
                //var bookID = textBoxBookIDLoans.Text;
                //var loanDate = dateTimePickerLoanDateLoans.Value;
                //DateTime? returnDate = checkBoxReturnDateLoans.Checked ? (DateTime?)null : dateTimePickerReturnDateLoans.Value;
                //var isReturned = textBoxIsReturnedLoans.Text;
                //var addQuery = $"insert into Loans (RegistrationID, BookID, LoanDate, ReturnDate, IsReturned) values ('{registrationID}', '{bookID}', '{loanDate:yyyy-MM-dd}', {returnDateValue}, '{isReturned}')";
                //var sqlCommand = new SqlCommand(addQuery, dataBase.GetConnection());
                //sqlCommand.ExecuteNonQuery();
                //MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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