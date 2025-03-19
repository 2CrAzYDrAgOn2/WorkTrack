using Microsoft.Office.Interop.Word;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Excel = Microsoft.Office.Interop.Excel;

namespace WorkTrack
{
    internal enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Form1 : Form
    {
        private readonly DataBase dataBase = new();
        private bool admin;
        private int selectedRow;
        private System.Windows.Forms.Timer timer;
        private NotifyIcon notifyIcon;

        public Form1(bool admin)
        {
            try
            {
                this.admin = admin;
                InitializeComponent();
                StartPosition = FormStartPosition.CenterScreen;
                InitializeNotifyIcon();
                InitializeTimer();
                ClearFields();
                ShowBalloonTip();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateColumns()
        {
            try
            {
                dataGridViewProjects.Columns.Add("ProjectID", "Номер");
                dataGridViewProjects.Columns.Add("ProjectName", "Название проекта");
                dataGridViewProjects.Columns.Add("Hourly", "Почасовая оплата");
                dataGridViewProjects.Columns.Add("PieceWork", "Сдельная оплата");
                dataGridViewProjects.Columns.Add("IsNew", String.Empty);
                dataGridViewEmployees.Columns.Add("EmployeeID", "Номер");
                dataGridViewEmployees.Columns.Add("FullName", "ФИО сотрудника");
                dataGridViewEmployees.Columns.Add("BirthDate", "Дата рождения");
                dataGridViewEmployees.Columns.Add("BirthPlace", "Место рождения");
                dataGridViewEmployees.Columns.Add("PassportSeries", "Серия паспорта");
                dataGridViewEmployees.Columns.Add("PassportNumber", "Номер паспорт");
                dataGridViewEmployees.Columns.Add("Phone", "Телефон");
                dataGridViewEmployees.Columns.Add("Email", "Почта");
                dataGridViewEmployees.Columns.Add("INN", "ИНН");
                dataGridViewEmployees.Columns.Add("PostID", "Должность");
                dataGridViewEmployees.Columns.Add("GenderID", "Пол");
                dataGridViewEmployees.Columns.Add("IsNew", String.Empty);
                dataGridViewSalaryAccruals.Columns.Add("SalaryAccrualID", "Номер");
                dataGridViewSalaryAccruals.Columns.Add("Year", "Год");
                dataGridViewSalaryAccruals.Columns.Add("MonthID", "Месяц");
                dataGridViewSalaryAccruals.Columns.Add("ProjectID", "Проект");
                dataGridViewSalaryAccruals.Columns.Add("IsNew", String.Empty);
                dataGridViewSalary.Columns.Add("SalaryID", "Номер");
                dataGridViewSalary.Columns.Add("SalaryAccrualID", "Номер зарплаты");
                dataGridViewSalary.Columns.Add("EmployeeID", "Номер сотрудника");
                dataGridViewSalary.Columns.Add("AllDays", "Дней отработано");
                dataGridViewSalary.Columns.Add("AllHours", "Часов отработано");
                dataGridViewSalary.Columns.Add("PieceworkCharges", "Сдельные начисления");
                dataGridViewSalary.Columns.Add("HourlyCharges", "Почасовые начисления");
                dataGridViewSalary.Columns.Add("VacationPay", "Отпускные");
                dataGridViewSalary.Columns.Add("SickPay", "Больничные");
                dataGridViewSalary.Columns.Add("PersonalIncomeTax", "НДФЛ");
                dataGridViewSalary.Columns.Add("Contributions", "Взносы");
                dataGridViewSalary.Columns.Add("Total", "Итого");
                dataGridViewSalary.Columns.Add("IsNew", String.Empty);
                dataGridViewAccountingsOfWorkingHours.Columns.Add("AccountingOfWorkingHoursID", "Номер");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("EmployeeID", "Сотрудник");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("ProjectID", "Проект");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("TypeOfRemunerationID", "Тип работы");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("HoursOfWork", "Количество");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("IsNew", String.Empty);
                dataGridViewVacationPay.Columns.Add("VacationPayID", "Номер");
                dataGridViewVacationPay.Columns.Add("EmployeeID", "Сотрудник");
                dataGridViewVacationPay.Columns.Add("VacationStartDate", "Дата начала отпуска");
                dataGridViewVacationPay.Columns.Add("VacationEndDate", "Дата конца отпуска");
                dataGridViewVacationPay.Columns.Add("AverageDailyEarnings", "Средний дневной заработок");
                dataGridViewVacationPay.Columns.Add("Total", "Итого");
                dataGridViewVacationPay.Columns.Add("IsNew", String.Empty);
                dataGridViewSickPay.Columns.Add("SickPayID", "Номер");
                dataGridViewSickPay.Columns.Add("EmployeeID", "Сотрудник");
                dataGridViewSickPay.Columns.Add("SickStartDate", "Дата начала больничного");
                dataGridViewSickPay.Columns.Add("SickEndDate", "Дата конца больничного");
                dataGridViewSickPay.Columns.Add("Experience", "Стаж работы");
                dataGridViewSickPay.Columns.Add("AverageDailyEarnings", "Средний дневной заработок");
                dataGridViewSickPay.Columns.Add("Total", "Итого");
                dataGridViewSickPay.Columns.Add("IsNew", String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            try
            {
                textBoxProjectID.Text = "";
                textBoxProjectName.Text = "";
                textBoxHourly.Text = "";
                textBoxPieceWork.Text = "";
                textBoxEmployeeID.Text = "";
                textBoxFullName.Text = "";
                textBoxBirthPlace.Text = "";
                textBoxPassportSeries.Text = "";
                textBoxPassportNumber.Text = "";
                maskedTextBoxPhone.Text = "";
                textBoxEmail.Text = "";
                textBoxINN.Text = "";
                textBoxSalaryAccrualID.Text = "";
                textBoxYear.Text = "";
                textBoxProjectIDSalaryAccruals.Text = "";
                textBoxSalaryID.Text = "";
                textBoxSalaryAccrualIDSalary.Text = "";
                textBoxEmployeeIDSalary.Text = "";
                textBoxAllDays.Text = "";
                textBoxAllHours.Text = "";
                textBoxPieceworkCharges.Text = "";
                textBoxHourlyCharges.Text = "";
                textBoxVacationPay.Text = "";
                textBoxSickPay.Text = "";
                textBoxPersonalIncomeTax.Text = "";
                textBoxContributions.Text = "";
                textBoxTotal.Text = "";
                textBoxAccountingsOfWorkingHoursID.Text = "";
                textBoxEmployeeIDAccountingsOfWorkingHours.Text = "";
                textBoxProjectIDAccountingsOfWorkingHours.Text = "";
                textBoxHoursOfWork.Text = "";
                textBoxVacationPayID.Text = "";
                textBoxEmployeeIDVacationPay.Text = "";
                textBoxAverageDailyEarnings.Text = "";
                textBoxTotalVacationPay.Text = "";
                textBoxSickPayID.Text = "";
                textBoxEmployeeID.Text = "";
                textBoxExperience.Text = "";
                textBoxAverageDailyEarningsSickPay.Text = "";
                textBoxTotalSickPay.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void ReadSingleRow(DataGridView dataGridView, IDataRecord iDataRecord)
        {
            try
            {
                switch (dataGridView.Name)
                {
                    case "dataGridViewProjects":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetDouble(2), iDataRecord.GetDouble(3), RowState.Modified);
                        break;

                    case "dataGridViewEmployees":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.IsDBNull(2) ? "" : iDataRecord.GetDateTime(2).ToString("yyyy-MM-dd"), iDataRecord.GetString(3), iDataRecord.GetString(4), iDataRecord.GetString(5), iDataRecord.GetString(6), iDataRecord.IsDBNull(7) ? "" : iDataRecord.GetString(7), iDataRecord.IsDBNull(8) ? "" : iDataRecord.GetString(8), iDataRecord.GetInt32(9), iDataRecord.GetInt32(10), RowState.Modified);
                        break;

                    case "dataGridViewSalaryAccruals":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetInt32(2), iDataRecord.GetInt32(3), RowState.Modified);
                        break;

                    case "dataGridViewSalary":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetInt32(2), iDataRecord.GetInt32(3), iDataRecord.GetInt32(4), iDataRecord.GetDouble(5), iDataRecord.GetDouble(6), iDataRecord.GetDouble(7), iDataRecord.GetDouble(8), iDataRecord.GetDouble(9), iDataRecord.GetDouble(10), iDataRecord.GetDouble(11), RowState.Modified);
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetInt32(2), iDataRecord.GetInt32(3), iDataRecord.GetInt32(4), RowState.Modified);
                        break;

                    case "dataGridViewVacationPay":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetDateTime(2).ToString("yyyy-MM-dd"), iDataRecord.GetDateTime(3).ToString("yyyy-MM-dd"), iDataRecord.GetDouble(4), iDataRecord.GetDouble(5), RowState.Modified);
                        break;

                    case "dataGridViewSickPay":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetDateTime(2).ToString("yyyy-MM-dd"), iDataRecord.GetDateTime(3).ToString("yyyy-MM-dd"), iDataRecord.GetInt32(4), iDataRecord.GetDouble(5), iDataRecord.GetDouble(6), RowState.Modified);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshDataGrid(DataGridView dataGridView, string tableName)
        {
            try
            {
                dataGridView.Rows.Clear();
                string queryString = $"select * from {tableName}";
                SqlCommand sqlCommand = new(queryString, dataBase.GetConnection());
                dataBase.OpenConnection();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ReadSingleRow(dataGridView, sqlDataReader);
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 3600000
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowBalloonTip();
        }

        private void ShowBalloonTip()
        {
            notifyIcon.BalloonTipTitle = "РусМитКонсерв";
            notifyIcon.BalloonTipText = $"Все права защищены.";
            notifyIcon.ShowBalloonTip(3000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CreateColumns();
                RefreshDataGrid(dataGridViewProjects, "Projects");
                RefreshDataGrid(dataGridViewEmployees, "Employees");
                RefreshDataGrid(dataGridViewSalaryAccruals, "SalaryAccruals");
                RefreshDataGrid(dataGridViewSalary, "Salary");
                RefreshDataGrid(dataGridViewAccountingsOfWorkingHours, "AccountingsOfWorkingHours");
                RefreshDataGrid(dataGridViewVacationPay, "VacationPay");
                RefreshDataGrid(dataGridViewSickPay, "SickPay");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_CellClick(DataGridView dataGridView, int selectedRow)
        {
            try
            {
                DataGridViewRow dataGridViewRow = dataGridView.Rows[selectedRow];
                switch (dataGridView.Name)
                {
                    case "dataGridViewProjects":
                        textBoxProjectID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        textBoxProjectName.Text = dataGridViewRow.Cells[1].Value.ToString();
                        textBoxHourly.Text = dataGridViewRow.Cells[2].Value.ToString();
                        textBoxPieceWork.Text = dataGridViewRow.Cells[3].Value.ToString();
                        break;

                    case "dataGridViewEmployees":
                        textBoxEmployeeID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        dateTimePickerBirthDate.Text = dataGridViewRow.Cells[1].Value.ToString();
                        textBoxAuthorBooks.Text = dataGridViewRow.Cells[2].Value.ToString();
                        textBoxBirthPlace.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxPassportSeries.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxPassportNumber.Text = dataGridViewRow.Cells[5].Value.ToString();
                        maskedTextBoxPhone.Text = dataGridViewRow.Cells[6].Value.ToString();
                        textBoxEmail.Text = dataGridViewRow.Cells[7].Value.ToString();
                        textBoxINN.Text = dataGridViewRow.Cells[8].Value.ToString();
                        var postID = dataGridViewRow.Cells[9].Value.ToString();
                        string queryPost = $"SELECT Post FROM Posts WHERE PostID = {postID}";
                        SqlCommand commandPost = new(queryPost, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultPost = commandPost.ExecuteScalar();
                        comboBoxPostID.Text = resultPost.ToString();
                        var genderID = dataGridViewRow.Cells[10].Value.ToString();
                        string queryGender = $"SELECT Gender FROM Genders WHERE GenderID = {genderID}";
                        SqlCommand commandGender = new(queryGender, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultGender = commandGender.ExecuteScalar();
                        comboBoxGenderID.Text = resultGender.ToString();
                        break;

                    case "dataGridViewSalaryAccruals":
                        textBoxSalaryAccrualID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        textBoxYear.Text = dataGridViewRow.Cells[1].Value.ToString();
                        var monthID = dataGridViewRow.Cells[2].Value.ToString();
                        string queryMonth = $"SELECT Month FROM Months WHERE MonthID = {monthID}";
                        SqlCommand commandMonth = new(queryMonth, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultMonth = commandMonth.ExecuteScalar();
                        comboBoxMonthID.Text = resultMonth.ToString();
                        var projectID = dataGridViewRow.Cells[3].Value.ToString();
                        string queryProject = $"SELECT ProjectName FROM Projects WHERE ProjectID = {projectID}";
                        SqlCommand commandProject = new(queryProject, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultProject = commandProject.ExecuteScalar();
                        textBoxProjectIDSalaryAccruals.Text = resultProject.ToString();
                        break;

                    case "dataGridViewSalary":
                        textBoxSalaryID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        textBoxSalaryAccrualIDSalary.Text = dataGridViewRow.Cells[1].Value.ToString();
                        var employeeID = dataGridViewRow.Cells[2].Value.ToString();
                        string queryEmployee = $"SELECT FullName FROM Employees WHERE EmployeeID = {employeeID}";
                        SqlCommand commandEmployee = new(queryEmployee, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultEmployee = commandEmployee.ExecuteScalar();
                        textBoxEmployeeIDSalary.Text = resultEmployee.ToString();
                        textBoxAllDays.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxAllHours.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxPieceworkCharges.Text = dataGridViewRow.Cells[5].Value.ToString();
                        textBoxHourlyCharges.Text = dataGridViewRow.Cells[6].Value.ToString();
                        textBoxVacationPay.Text = dataGridViewRow.Cells[7].Value.ToString();
                        textBoxSickPay.Text = dataGridViewRow.Cells[8].Value.ToString();
                        textBoxPersonalIncomeTax.Text = dataGridViewRow.Cells[9].Value.ToString();
                        textBoxContributions.Text = dataGridViewRow.Cells[10].Value.ToString();
                        textBoxTotal.Text = dataGridViewRow.Cells[11].Value.ToString();
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        textBoxAccountingsOfWorkingHoursID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        var employeeIDAccountingsOfWorkingHours = dataGridViewRow.Cells[1].Value.ToString();
                        string queryEmployeeAccountingsOfWorkingHours = $"SELECT FullName FROM Employees WHERE EmployeeID = {employeeIDAccountingsOfWorkingHours}";
                        SqlCommand commandEmployeeAccountingsOfWorkingHours = new(queryEmployeeAccountingsOfWorkingHours, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultEmployeeAccountingsOfWorkingHours = commandEmployeeAccountingsOfWorkingHours.ExecuteScalar();
                        textBoxEmployeeIDAccountingsOfWorkingHours.Text = resultEmployeeAccountingsOfWorkingHours.ToString();
                        var projectIDAccountingsOfWorkingHours = dataGridViewRow.Cells[2].Value.ToString();
                        string queryProjectAccountingsOfWorkingHours = $"SELECT ProjectName FROM Projects WHERE ProjectID = {projectIDAccountingsOfWorkingHours}";
                        SqlCommand commandProjectAccountingsOfWorkingHours = new(queryProjectAccountingsOfWorkingHours, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultProjectAccountingsOfWorkingHours = commandProjectAccountingsOfWorkingHours.ExecuteScalar();
                        textBoxProjectIDAccountingsOfWorkingHours.Text = resultProjectAccountingsOfWorkingHours.ToString();
                        var TypeOfRemunerationID = dataGridViewRow.Cells[3].Value.ToString();
                        string queryTypeOfRemuneration = $"SELECT TypeOfRemuneration FROM TypesOfRemuneration WHERE TypeOfRemunerationID = {TypeOfRemunerationID}";
                        SqlCommand commandTypeOfRemuneration = new(queryTypeOfRemuneration, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultTypeOfRemuneration = commandTypeOfRemuneration.ExecuteScalar();
                        comboBoxTypeOfRemunerationID.Text = resultTypeOfRemuneration.ToString();
                        textBoxHoursOfWork.Text = dataGridViewRow.Cells[4].Value.ToString();
                        break;

                    case "dataGridViewVacationPay":
                        textBoxVacationPayID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        var employeeIDVacationPay = dataGridViewRow.Cells[1].Value.ToString();
                        string queryVacationPay = $"SELECT FullName FROM Employees WHERE EmployeeID = {employeeIDVacationPay}";
                        SqlCommand commandVacationPay = new(queryVacationPay, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultVacationPay = commandVacationPay.ExecuteScalar();
                        textBoxEmployeeIDVacationPay.Text = resultVacationPay.ToString();
                        dateTimePickerVacationStartDate.Text = dataGridViewRow.Cells[2].Value.ToString();
                        dateTimePickerVacationEndDate.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxAverageDailyEarnings.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxTotalVacationPay.Text = dataGridViewRow.Cells[5].Value.ToString();
                        break;

                    case "dataGridViewSickPay":
                        textBoxSickPayID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        var employeeIDSickPay = dataGridViewRow.Cells[1].Value.ToString();
                        string querySickPay = $"SELECT FullName FROM Employees WHERE EmployeeID = {employeeIDSickPay}";
                        SqlCommand commandSickPay = new(querySickPay, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object resultSickPay = commandSickPay.ExecuteScalar();
                        textBoxEmployeeIDSickPay.Text = resultSickPay.ToString();
                        dateTimePickerSickStartDate.Text = dataGridViewRow.Cells[2].Value.ToString();
                        dateTimePickerSickEndDate.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxExperience.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxAverageDailyEarningsSickPay.Text = dataGridViewRow.Cells[5].Value.ToString();
                        textBoxTotalSickPay.Text = dataGridViewRow.Cells[6].Value.ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search(DataGridView dataGridView)
        {
            try
            {
                dataGridView.Rows.Clear();
                switch (dataGridView.Name)
                {
                    case "dataGridViewProjects":
                        string searchStringProjects = $"select * from Projects where concat (ProjectID, ProjectName, Hourly, PieceWork) like '%" + textBoxSearchProjects.Text + "%'";
                        SqlCommand sqlCommandProjects = new(searchStringProjects, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        SqlDataReader sqlDataReaderProjects = sqlCommandProjects.ExecuteReader();
                        while (sqlDataReaderProjects.Read())
                        {
                            ReadSingleRow(dataGridView, sqlDataReaderProjects);
                        }
                        sqlDataReaderProjects.Close();
                        break;

                    case "dataGridViewEmployees":
                        string searchStringEmployees = $"select * from Employees where concat (EmployeeID, FullName, BirthDate, BirthPlace, PassportSeries, PassportNumber, Phone, Email, INN, PostID, GenderID) like '%" + textBoxSearchEmployees.Text + "%'";
                        SqlCommand sqlCommandEmployees = new(searchStringEmployees, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        SqlDataReader sqlDataReaderEmployees = sqlCommandEmployees.ExecuteReader();
                        while (sqlDataReaderEmployees.Read())
                        {
                            ReadSingleRow(dataGridView, sqlDataReaderEmployees);
                        }
                        sqlDataReaderEmployees.Close();
                        break;

                    case "dataGridViewSalaryAccruals":
                        string searchStringSalaryAccruals = $"select * from SalaryAccruals where concat (SalaryAccrualID, Year, MonthID, ProjectID) like '%" + textBoxSearchSalaryAccruals.Text + "%'";
                        SqlCommand sqlCommandSalaryAccruals = new(searchStringSalaryAccruals, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        SqlDataReader sqlDataReaderSalaryAccruals = sqlCommandSalaryAccruals.ExecuteReader();
                        while (sqlDataReaderSalaryAccruals.Read())
                        {
                            ReadSingleRow(dataGridView, sqlDataReaderSalaryAccruals);
                        }
                        sqlDataReaderSalaryAccruals.Close();
                        break;

                    case "dataGridViewSalary":
                        string searchStringSalary = $"select * from Salary where concat (SalaryID, SalaryAccrualID, EmployeeID, AllDays, AllHours, PieceworkCharges, HourlyCharges, VacationPay, SickPay, PersonalIncomeTax, Contributions, Total) like '%" + textBoxSearchSalary.Text + "%'";
                        SqlCommand sqlCommandSalary = new(searchStringSalary, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        SqlDataReader sqlDataReaderSalary = sqlCommandSalary.ExecuteReader();
                        while (sqlDataReaderSalary.Read())
                        {
                            ReadSingleRow(dataGridView, sqlDataReaderSalary);
                        }
                        sqlDataReaderSalary.Close();
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        string searchStringAccountingsOfWorkingHours = $"select * from AccountingsOfWorkingHours where concat (AccountingOfWorkingHoursID, EmployeeID, ProjectID, TypeOfRemunerationID, HoursOfWork) like '%" + textBoxSearchAccountingsOfWorkingHours.Text + "%'";
                        SqlCommand sqlCommandAccountingsOfWorkingHours = new(searchStringAccountingsOfWorkingHours, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        SqlDataReader sqlDataReaderAccountingsOfWorkingHours = sqlCommandAccountingsOfWorkingHours.ExecuteReader();
                        while (sqlDataReaderAccountingsOfWorkingHours.Read())
                        {
                            ReadSingleRow(dataGridView, sqlDataReaderAccountingsOfWorkingHours);
                        }
                        sqlDataReaderAccountingsOfWorkingHours.Close();
                        break;

                    case "dataGridViewVacationPay":
                        string searchStringVacationPay = $"select * from VacationPay where concat (VacationPayID, EmployeeID, VacationStartDate, VacationEndDate, AverageDailyEarnings, Total) like '%" + textBoxSearchVacationPay.Text + "%'";
                        SqlCommand sqlCommandVacationPay = new(searchStringVacationPay, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        SqlDataReader sqlDataReaderVacationPay = sqlCommandVacationPay.ExecuteReader();
                        while (sqlDataReaderVacationPay.Read())
                        {
                            ReadSingleRow(dataGridView, sqlDataReaderVacationPay);
                        }
                        sqlDataReaderVacationPay.Close();
                        break;

                    case "dataGridViewSickPay":
                        string searchStringSickPay = $"select * from SickPay where concat (SickPayID, EmployeeID, SickStartDate, SickEndDate, Experience, AverageDailyEarnings, Total) like '%" + textBoxSearchSickPay.Text + "%'";
                        SqlCommand sqlCommandSickPay = new(searchStringSickPay, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        SqlDataReader sqlDataReaderSickPay = sqlCommandSickPay.ExecuteReader();
                        while (sqlDataReaderSickPay.Read())
                        {
                            ReadSingleRow(dataGridView, sqlDataReaderSickPay);
                        }
                        sqlDataReaderSickPay.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void DeleteRow(DataGridView dataGridView)
        {
            try
            {
                int index = dataGridView.CurrentCell.RowIndex;
                dataGridView.Rows[index].Visible = false;
                switch (dataGridView.Name)
                {
                    case "dataGridViewProjects":
                        if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
                        {
                            dataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                        break;

                    case "dataGridViewEmployees":
                        if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
                        {
                            dataGridView.Rows[index].Cells[11].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[11].Value = RowState.Deleted;
                        break;

                    case "dataGridViewSalaryAccruals":
                        if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
                        {
                            dataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[4].Value = RowState.Deleted;
                        break;

                    case "dataGridViewSalary":
                        if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
                        {
                            dataGridView.Rows[index].Cells[12].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[12].Value = RowState.Deleted;
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
                        {
                            dataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[5].Value = RowState.Deleted;
                        break;

                    case "dataGridViewVacationPay":
                        if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
                        {
                            dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[6].Value = RowState.Deleted;
                        break;

                    case "dataGridViewSickPay":
                        if (dataGridView.Rows[index].Cells[0].Value.ToString() == string.Empty)
                        {
                            dataGridView.Rows[index].Cells[7].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[7].Value = RowState.Deleted;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBase(DataGridView dataGridView)
        {
            try
            {
                dataBase.OpenConnection();
                for (int index = 0; index < dataGridView.Rows.Count; index++)
                {
                    switch (dataGridView.Name)
                    {
                        case "dataGridViewProjects":
                            var rowStateProjects = (RowState)dataGridView.Rows[index].Cells[4].Value;
                            if (rowStateProjects == RowState.Existed)
                            {
                                continue;
                            }
                            if (rowStateProjects == RowState.Deleted)
                            {
                                var projectID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                                var deleteQuery = $"delete from Projects where ProjectID = '{projectID}'";
                                var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateProjects == RowState.Modified)
                            {
                                var projectID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var projectName = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var hourly = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var pieceWork = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var changeQuery = $"update Projects set ProjectName = '{projectName}', Hourly = '{hourly}', PieceWork = '{pieceWork}' where ProjectID = '{projectID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateProjects == RowState.New)
                            {
                                var projectName = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var hourly = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var pieceWork = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var newQuery = $"insert into Projects (ProjectName, Hourly, PieceWork) values ('{projectName}', '{hourly}', '{pieceWork}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            break;

                        case "dataGridViewEmployees":
                            var rowStateEmployees = (RowState)dataGridView.Rows[index].Cells[11].Value;
                            if (rowStateEmployees == RowState.Existed)
                            {
                                continue;
                            }
                            if (rowStateEmployees == RowState.Deleted)
                            {
                                var employeeID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                                var deleteQuery = $"delete from Employees where EmployeeID = '{employeeID}'";
                                var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateEmployees == RowState.Modified)
                            {
                                var employeeID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var fullName = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var birthDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var birthPlace = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var passportSeries = dataGridView.Rows[index].Cells[4].Value.ToString();
                                var passportNumber = dataGridView.Rows[index].Cells[5].Value.ToString();
                                var phone = dataGridView.Rows[index].Cells[6].Value.ToString();
                                var email = dataGridView.Rows[index].Cells[7].Value.ToString();
                                var iNN = dataGridView.Rows[index].Cells[8].Value.ToString();
                                var postID = dataGridView.Rows[index].Cells[9].Value.ToString();
                                var genderID = dataGridView.Rows[index].Cells[10].Value.ToString();
                                var changeQuery = $"update Employees set FullName = '{fullName}', BirthDate = '{birthDate}', BirthPlace = '{birthPlace}', PassportSeries = '{passportSeries}', PassportNumber = '{passportNumber}', Phone = '{phone}', Email = '{email}', INN = '{iNN}', PostID = '{postID}', GenderID = '{genderID}' where EmployeeID = '{employeeID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateEmployees == RowState.New)
                            {
                                var fullName = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var birthDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var birthPlace = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var passportSeries = dataGridView.Rows[index].Cells[4].Value.ToString();
                                var passportNumber = dataGridView.Rows[index].Cells[5].Value.ToString();
                                var phone = dataGridView.Rows[index].Cells[6].Value.ToString();
                                var email = dataGridView.Rows[index].Cells[7].Value.ToString();
                                var iNN = dataGridView.Rows[index].Cells[8].Value.ToString();
                                var postID = dataGridView.Rows[index].Cells[9].Value.ToString();
                                var genderID = dataGridView.Rows[index].Cells[10].Value.ToString();
                                var newQuery = $"insert into Employees (FullName, BirthDate, BirthPlace, PassportSeries, PassportNumber, Phone, Email, INN, PostID, GenderID) values ('{fullName}', '{birthDate}', '{birthPlace}', '{passportSeries}', '{passportNumber}', '{phone}', '{email}', '{iNN}', '{postID}', '{genderID}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            break;

                        case "dataGridViewSalaryAccruals":
                            var rowStateSalaryAccruals = (RowState)dataGridView.Rows[index].Cells[4].Value;
                            if (rowStateSalaryAccruals == RowState.Existed)
                            {
                                continue;
                            }
                            if (rowStateSalaryAccruals == RowState.Deleted)
                            {
                                var salaryAccrualID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                                var deleteQuery = $"delete from SalaryAccruals where SalaryAccrualID = '{salaryAccrualID}'";
                                var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSalaryAccruals == RowState.Modified)
                            {
                                var salaryAccrualID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var year = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var monthID = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var projectID = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var changeQuery = $"update SalaryAccruals set Year = '{year}', MonthID = '{monthID}', ProjectID = '{projectID}' where SalaryAccrualID = '{salaryAccrualID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSalaryAccruals == RowState.New)
                            {
                                var year = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var monthID = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var projectID = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var newQuery = $"insert into SalaryAccruals (Year, MonthID, ProjectID) values ('{year}', '{monthID}', '{projectID}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            break;

                        case "dataGridViewSalary":
                            var rowStateSalary = (RowState)dataGridView.Rows[index].Cells[12].Value;
                            if (rowStateSalary == RowState.Existed)
                            {
                                continue;
                            }
                            if (rowStateSalary == RowState.Deleted)
                            {
                                var salaryID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                                var deleteQuery = $"delete from Salary where SalaryID = '{salaryID}'";
                                var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSalary == RowState.Modified)
                            {
                                var salaryID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var salaryAccrualID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var employeeID = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var changeQuery = $"update Salary set SalaryAccrualID = '{salaryAccrualID}', EmployeeID = '{employeeID}' where SalaryID = '{salaryID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSalary == RowState.New)
                            {
                                var salaryAccrualID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var employeeID = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var newQuery = $"insert into Salary (SalaryAccrualID, EmployeeID) values ('{salaryAccrualID}', '{employeeID}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            break;

                        case "dataGridViewAccountingsOfWorkingHours":
                            var rowStateAccountingsOfWorkingHours = (RowState)dataGridView.Rows[index].Cells[5].Value;
                            if (rowStateAccountingsOfWorkingHours == RowState.Existed)
                            {
                                continue;
                            }
                            if (rowStateAccountingsOfWorkingHours == RowState.Deleted)
                            {
                                var accountingOfWorkingHoursID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                                var deleteQuery = $"delete from AccountingsOfWorkingHours where AccountingOfWorkingHoursID = '{accountingOfWorkingHoursID}'";
                                var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateAccountingsOfWorkingHours == RowState.Modified)
                            {
                                var accountingOfWorkingHoursID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var employeeID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var projectID = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var typeOfRemunerationID = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var hoursOfWork = dataGridView.Rows[index].Cells[4].Value.ToString();
                                var changeQuery = $"update AccountingsOfWorkingHours set EmployeeID = '{employeeID}', ProjectID = '{projectID}', TypeOfRemunerationID = '{typeOfRemunerationID}', HoursOfWork = '{hoursOfWork}' where AccountingOfWorkingHoursID = '{accountingOfWorkingHoursID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateAccountingsOfWorkingHours == RowState.New)
                            {
                                var employeeID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var projectID = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var typeOfRemunerationID = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var hoursOfWork = dataGridView.Rows[index].Cells[4].Value.ToString();
                                var newQuery = $"insert into AccountingsOfWorkingHours (EmployeeID, ProjectID, TypeOfRemunerationID, HoursOfWork) values ('{employeeID}', '{projectID}', '{typeOfRemunerationID}', '{hoursOfWork}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            break;

                        case "dataGridViewVacationPay":
                            var rowStateVacationPay = (RowState)dataGridView.Rows[index].Cells[6].Value;
                            if (rowStateVacationPay == RowState.Existed)
                            {
                                continue;
                            }
                            if (rowStateVacationPay == RowState.Deleted)
                            {
                                var vacationPayID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                                var deleteQuery = $"delete from VacationPay where VacationPayID = '{vacationPayID}'";
                                var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateVacationPay == RowState.Modified)
                            {
                                var vacationPayID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var employeeID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var vacationStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var vacationEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var changeQuery = $"update VacationPay set EmployeeID = '{employeeID}', VacationStartDate = '{vacationStartDate}', VacationEndDate = '{vacationEndDate}' where VacationPayID = '{vacationPayID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateVacationPay == RowState.New)
                            {
                                var employeeID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var vacationStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var vacationEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var newQuery = $"insert into VacationPay (EmployeeID, VacationStartDate, VacationEndDate) values ('{employeeID}', '{vacationStartDate}', '{vacationEndDate}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            break;

                        case "dataGridViewSickPay":
                            var rowStateSickPay = (RowState)dataGridView.Rows[index].Cells[7].Value;
                            if (rowStateSickPay == RowState.Existed)
                            {
                                continue;
                            }
                            if (rowStateSickPay == RowState.Deleted)
                            {
                                var sickPayID = Convert.ToInt32(dataGridView.Rows[index].Cells[0].Value);
                                var deleteQuery = $"delete from SickPay where SickPayID = '{sickPayID}'";
                                var sqlCommand = new SqlCommand(deleteQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSickPay == RowState.Modified)
                            {
                                var sickPayID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var employeeID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var sickStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var sickEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var changeQuery = $"update SickPay set EmployeeID = '{employeeID}', SickStartDate = '{sickStartDate}', SickEndDate = '{sickEndDate}' where SickPayID = '{sickPayID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSickPay == RowState.New)
                            {
                                var employeeID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var sickStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var sickEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var newQuery = $"insert into SickPay (EmployeeID, SickStartDate, SickEndDate) values ('{employeeID}', '{sickStartDate}', '{sickEndDate}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            break;
                    }
                }
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

        private void Change(DataGridView dataGridView)
        {
            try
            {
                var selectedRowIndex = dataGridView.CurrentCell.RowIndex;
                switch (dataGridView.Name)
                {
                    case "dataGridViewBooks":
                        var bookID = textBoxBookID.Text;
                        var titleBooks = textBoxTitleBooks.Text;
                        var authorBooks = textBoxAuthorBooks.Text;
                        var genreBooks = textBoxGenreBooks.Text;
                        var publishedYearBooks = textBoxPublishedYearBooks.Text;
                        var iSBNBooks = textBoxISBNBooks.Text;
                        var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;

                    case "dataGridViewBooks":
                        var bookID = textBoxBookID.Text;
                        var titleBooks = textBoxTitleBooks.Text;
                        var authorBooks = textBoxAuthorBooks.Text;
                        var genreBooks = textBoxGenreBooks.Text;
                        var publishedYearBooks = textBoxPublishedYearBooks.Text;
                        var iSBNBooks = textBoxISBNBooks.Text;
                        var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;

                    case "dataGridViewBooks":
                        var bookID = textBoxBookID.Text;
                        var titleBooks = textBoxTitleBooks.Text;
                        var authorBooks = textBoxAuthorBooks.Text;
                        var genreBooks = textBoxGenreBooks.Text;
                        var publishedYearBooks = textBoxPublishedYearBooks.Text;
                        var iSBNBooks = textBoxISBNBooks.Text;
                        var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;

                    case "dataGridViewBooks":
                        var bookID = textBoxBookID.Text;
                        var titleBooks = textBoxTitleBooks.Text;
                        var authorBooks = textBoxAuthorBooks.Text;
                        var genreBooks = textBoxGenreBooks.Text;
                        var publishedYearBooks = textBoxPublishedYearBooks.Text;
                        var iSBNBooks = textBoxISBNBooks.Text;
                        var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;

                    case "dataGridViewBooks":
                        var bookID = textBoxBookID.Text;
                        var titleBooks = textBoxTitleBooks.Text;
                        var authorBooks = textBoxAuthorBooks.Text;
                        var genreBooks = textBoxGenreBooks.Text;
                        var publishedYearBooks = textBoxPublishedYearBooks.Text;
                        var iSBNBooks = textBoxISBNBooks.Text;
                        var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;

                    case "dataGridViewBooks":
                        var bookID = textBoxBookID.Text;
                        var titleBooks = textBoxTitleBooks.Text;
                        var authorBooks = textBoxAuthorBooks.Text;
                        var genreBooks = textBoxGenreBooks.Text;
                        var publishedYearBooks = textBoxPublishedYearBooks.Text;
                        var iSBNBooks = textBoxISBNBooks.Text;
                        var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;

                    case "dataGridViewBooks":
                        var bookID = textBoxBookID.Text;
                        var titleBooks = textBoxTitleBooks.Text;
                        var authorBooks = textBoxAuthorBooks.Text;
                        var genreBooks = textBoxGenreBooks.Text;
                        var publishedYearBooks = textBoxPublishedYearBooks.Text;
                        var iSBNBooks = textBoxISBNBooks.Text;
                        var copiesAvailableBooks = textBoxCopiesAvailableBooks.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(bookID, titleBooks, authorBooks, genreBooks, publishedYearBooks, iSBNBooks, copiesAvailableBooks);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;

                    case "dataGridViewLoans":
                        var loanID = textBoxLoanID.Text;
                        var userLogin = textBoxRegistrationIDLoans.Text;
                        string query = $"SELECT RegistrationID FROM Registration WHERE UserLogin = '{userLogin}'";
                        SqlCommand command = new(query, dataBase.GetConnection());
                        dataBase.OpenConnection();
                        object result = command.ExecuteScalar();
                        var registrationIDLoans = result.ToString();
                        var bookIDLoans = textBoxBookIDLoans.Text;
                        var loanDateLoans = dateTimePickerLoanDateLoans.Value;
                        DateTime? returnDateLoans = dateTimePickerReturnDateLoans.Value;
                        var isReturnedLoans = textBoxIsReturnedLoans.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(loanID, registrationIDLoans, bookIDLoans, loanDateLoans, returnDateLoans, isReturnedLoans);
                        dataGridView.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportToWord(DataGridView dataGridView)
        {
            try
            {
                var wordApp = new Microsoft.Office.Interop.Word.Application
                {
                    Visible = true
                };
                Document doc = wordApp.Documents.Add();
                Paragraph title = doc.Paragraphs.Add();
                switch (dataGridView.Name)
                {
                    case "dataGridViewProjects":
                        title.Range.Text = "Данные проектов";
                        break;

                    case "dataGridViewEmployees":
                        title.Range.Text = "Данные сотрудников";
                        break;

                    case "dataGridViewSalaryAccruals":
                        title.Range.Text = "Данные зарплат";
                        break;

                    case "dataGridViewSalary":
                        title.Range.Text = "Данные начислений зарплат";
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        title.Range.Text = "Данные учета времени";
                        break;

                    case "dataGridViewVacationPay":
                        title.Range.Text = "Данные рассчета отпусков";
                        break;

                    case "dataGridViewSickPay":
                        title.Range.Text = "Данные рассчета больничных";
                        break;
                }
                title.Range.Font.Bold = 1;
                title.Range.Font.Size = 14;
                title.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();
                Table table = doc.Tables.Add(title.Range, dataGridView.RowCount + 1, dataGridView.ColumnCount - 1);
                for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                {
                    table.Cell(1, col + 1).Range.Text = dataGridView.Columns[col].HeaderText;
                }
                for (int row = 0; row < dataGridView.RowCount; row++)
                {
                    for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                    {
                        table.Cell(row + 2, col + 1).Range.Text = dataGridView[col, row].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExportToExcel(DataGridView dataGridView)
        {
            try
            {
                Excel.Application excelApp = new()
                {
                    Visible = true
                };
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                string title = "";
                switch (dataGridView.Name)
                {
                    case "dataGridViewProjects":
                        title = "Данные проектов";
                        break;

                    case "dataGridViewEmployees":
                        title = "Данные сотрудников";
                        break;

                    case "dataGridViewSalaryAccruals":
                        title = "Данные зарплат";
                        break;

                    case "dataGridViewSalary":
                        title = "Данные начислений зарплат";
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        title = "Данные учета времени";
                        break;

                    case "dataGridViewVacationPay":
                        title = "Данные рассчета отпусков";
                        break;

                    case "dataGridViewSickPay":
                        title = "Данные рассчета больничных";
                        break;
                }
                Excel.Range titleRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dataGridView.ColumnCount - 1]];
                titleRange.Merge();
                titleRange.Value = title;
                titleRange.Font.Bold = true;
                titleRange.Font.Size = 14;
                titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                for (int col = 0; col < dataGridView.ColumnCount; col++)
                {
                    worksheet.Cells[2, col + 1] = dataGridView.Columns[col].HeaderText;
                }
                for (int row = 0; row < dataGridView.RowCount; row++)
                {
                    for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                    {
                        worksheet.Cells[row + 3, col + 1] = dataGridView[col, row].Value.ToString();
                        Excel.Range dataRange = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[dataGridView.RowCount + 2, dataGridView.ColumnCount]];
                        dataRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        dataRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    }
                }
                worksheet.Columns.AutoFit();
                worksheet.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static void ExportToTXT(DataGridView dataGridView)
        {
            string text = "";
            switch (dataGridView.Name)
            {
                case "dataGridViewProjects":
                    text += "Данные проектов\n\n";
                    break;

                case "dataGridViewEmployees":
                    text += "Данные сотрудников\n\n";
                    break;

                case "dataGridViewSalaryAccruals":
                    text += "Данные зарплат\n\n";
                    break;

                case "dataGridViewSalary":
                    text += "Данные начислений зарплат\n\n";
                    break;

                case "dataGridViewAccountingsOfWorkingHours":
                    text += "Данные учета времени\n\n";
                    break;

                case "dataGridViewVacationPay":
                    text += "Данные рассчета отпусков\n\n";
                    break;

                case "dataGridViewSickPay":
                    text += "Данные рассчета больничных\n\n";
                    break;
            }
            for (int col = 0; col < dataGridView.ColumnCount; col++)
            {
                text += dataGridView.Columns[col].HeaderText + "\t";
            }
            text += "\n";
            for (int row = 0; row < dataGridView.RowCount; row++)
            {
                for (int col = 0; col < dataGridView.ColumnCount - 1; col++)
                {
                    text += dataGridView[col, row].Value?.ToString() + "\t";
                }
                text += "\n";
            }
            string filePath = "данные.txt";
            File.WriteAllText(filePath, text);
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshDataGrid(dataGridViewProjects, "Projects");
                RefreshDataGrid(dataGridViewEmployees, "Employees");
                RefreshDataGrid(dataGridViewSalaryAccruals, "SalaryAccruals");
                RefreshDataGrid(dataGridViewSalary, "Salary");
                RefreshDataGrid(dataGridViewAccountingsOfWorkingHours, "AccountingsOfWorkingHours");
                RefreshDataGrid(dataGridViewVacationPay, "VacationPay");
                RefreshDataGrid(dataGridViewSickPay, "SickPay");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void ButtonNewBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AddFormBooks addForm = new();
        //        addForm.Show();
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonNewLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        AddFormLoans addForm = new();
        //        addForm.Show();
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonDeleteBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DeleteRow(dataGridViewBooks);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonDeleteLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DeleteRow(dataGridViewProjects);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonChangeBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Change(dataGridViewBooks);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonChangeLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Change(dataGridViewProjects);
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonSaveBook_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (admin)
        //        {
        //            UpdateBase(dataGridViewBooks);
        //        }
        //        else
        //        {
        //            MessageBox.Show("У вас недостаточно прав!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void ButtonSaveLoan_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        UpdateBase(dataGridViewProjects);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void ButtonNewProject_Click(object sender, EventArgs e)
        {
        }

        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
        }

        private void ButtonNewSalaryAccrual_Click(object sender, EventArgs e)
        {
        }

        private void ButtonNewSalary_Click(object sender, EventArgs e)
        {
        }

        private void ButtonNewAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
        }

        private void ButtonNewVacationPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonNewSickPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteProject_Click(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteSalaryAccrual_Click(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteSalary_Click(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteVacationPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonDeleteSickPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChangeProject_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChangeEmployee_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChangeSalaryAccrual_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChangeSalary_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChangeAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChangeVacationPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChangeSickPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveProject_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveEmployee_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveSalaryAccrual_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveSalary_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveVacationPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonSaveSickPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonWordProject_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewProjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonWordEmployee_Click(object sender, EventArgs e)
        {
        }

        private void ButtonWordSalaryAccrual_Click(object sender, EventArgs e)
        {
        }

        private void ButtonWordSalary_Click(object sender, EventArgs e)
        {
        }

        private void ButtonWordAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
        }

        private void ButtonWordVacationPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonWordSickPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonExcelProject_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewProjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonExcelEmployee_Click(object sender, EventArgs e)
        {
        }

        private void ButtonExcelSalaryAccrual_Click(object sender, EventArgs e)
        {
        }

        private void ButtonExcelSalary_Click(object sender, EventArgs e)
        {
        }

        private void ButtonExcelAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
        }

        private void ButtonExcelVacationPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonExcelSickPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonTXTProject_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToTXT(dataGridViewProjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonTXTEmployee_Click(object sender, EventArgs e)
        {
        }

        private void ButtonTXTSalaryAccrual_Click(object sender, EventArgs e)
        {
        }

        private void ButtonTXTSalary_Click(object sender, EventArgs e)
        {
        }

        private void ButtonTXTAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
        }

        private void ButtonTXTVacationPay_Click(object sender, EventArgs e)
        {
        }

        private void ButtonTXTSickPay_Click(object sender, EventArgs e)
        {
        }

        private void DataGridViewProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewSalaryAccruals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewAccountingsOfWorkingHours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewVacationPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DataGridViewSickPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TextBoxSearchProjects_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSearchEmployees_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSearchSalaryAccruals_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSearchSalary_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSearchAccountingsOfWorkingHours_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSearchVacationPay_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxSearchSickPay_TextChanged(object sender, EventArgs e)
        {
        }

        //private void DataGridViewBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        selectedRow = e.RowIndex;
        //        if (e.RowIndex >= 0)
        //        {
        //            DataGridView_CellClick(dataGridViewBooks, selectedRow);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void DataGridViewLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        selectedRow = e.RowIndex;
        //        if (e.RowIndex >= 0)
        //        {
        //            DataGridView_CellClick(dataGridViewProjects, selectedRow);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void TextBoxSearchBooks_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Search(dataGridViewBooks);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void TextBoxSearchLoans_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Search(dataGridViewProjects);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}