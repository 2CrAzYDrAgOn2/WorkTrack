using Microsoft.Office.Interop.Word;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Application = Microsoft.Office.Interop.Word.Application;
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

        /// <summary>
        /// Form1() вызывается при открытии формы
        /// </summary>
        /// <param name="admin"></param>
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

        /// <summary>
        /// CreateColumns() вызывается при создании колонок
        /// </summary>
        private void CreateColumns()
        {
            try
            {
                dataGridViewProjects.Columns.Add("Номер", "Номер");
                dataGridViewProjects.Columns.Add("Название проекта", "Название проекта");
                dataGridViewProjects.Columns.Add("Почасовая оплата", "Почасовая оплата");
                dataGridViewProjects.Columns.Add("Сдельная оплата", "Сдельная оплата");
                dataGridViewProjects.Columns.Add("IsNew", String.Empty);
                dataGridViewEmployees.Columns.Add("Номер", "Номер");
                dataGridViewEmployees.Columns.Add("ФИО сотрудника", "ФИО сотрудника");
                dataGridViewEmployees.Columns.Add("Дата рождения", "Дата рождения");
                dataGridViewEmployees.Columns.Add("Место рождения", "Место рождения");
                dataGridViewEmployees.Columns.Add("Серия паспорта", "Серия паспорта");
                dataGridViewEmployees.Columns.Add("Номер паспорт", "Номер паспорт");
                dataGridViewEmployees.Columns.Add("Телефон", "Телефон");
                dataGridViewEmployees.Columns.Add("Почта", "Почта");
                dataGridViewEmployees.Columns.Add("ИНН", "ИНН");
                dataGridViewEmployees.Columns.Add("Дата устройства", "Дата устройства");
                dataGridViewEmployees.Columns.Add("Должность", "Должность");
                dataGridViewEmployees.Columns.Add("Пол", "Пол");
                dataGridViewEmployees.Columns.Add("IsNew", String.Empty);
                dataGridViewSalaryAccruals.Columns.Add("Номер", "Номер");
                dataGridViewSalaryAccruals.Columns.Add("Год", "Год");
                dataGridViewSalaryAccruals.Columns.Add("Месяц", "Месяц");
                dataGridViewSalaryAccruals.Columns.Add("Проект", "Проект");
                dataGridViewSalaryAccruals.Columns.Add("IsNew", String.Empty);
                dataGridViewSalary.Columns.Add("Номер", "Номер");
                dataGridViewSalary.Columns.Add("Номер зарплаты", "Номер зарплаты");
                dataGridViewSalary.Columns.Add("Номер сотрудника", "Номер сотрудника");
                dataGridViewSalary.Columns.Add("Дней отработано", "Дней отработано");
                dataGridViewSalary.Columns.Add("Часов отработано", "Часов отработано");
                dataGridViewSalary.Columns.Add("Сдельные начисления", "Сдельные начисления");
                dataGridViewSalary.Columns.Add("Почасовые начисления", "Почасовые начисления");
                dataGridViewSalary.Columns.Add("Отпускные", "Отпускные");
                dataGridViewSalary.Columns.Add("Больничные", "Больничные");
                dataGridViewSalary.Columns.Add("НДФЛ", "НДФЛ");
                dataGridViewSalary.Columns.Add("Взносы", "Взносы");
                dataGridViewSalary.Columns.Add("Итого", "Итого");
                dataGridViewSalary.Columns.Add("IsNew", String.Empty);
                dataGridViewAccountingsOfWorkingHours.Columns.Add("Номер", "Номер");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("Сотрудник", "Сотрудник");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("Проект", "Проект");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("Тип работы", "Тип работы");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("Количество", "Количество");
                dataGridViewAccountingsOfWorkingHours.Columns.Add("IsNew", String.Empty);
                dataGridViewVacationPay.Columns.Add("Номер", "Номер");
                dataGridViewVacationPay.Columns.Add("Сотрудник", "Сотрудник");
                dataGridViewVacationPay.Columns.Add("Дата начала отпуска", "Дата начала отпуска");
                dataGridViewVacationPay.Columns.Add("Дата конца отпуска", "Дата конца отпуска");
                dataGridViewVacationPay.Columns.Add("Средний дневной заработок", "Средний дневной заработок");
                dataGridViewVacationPay.Columns.Add("Итого", "Итого");
                dataGridViewVacationPay.Columns.Add("IsNew", String.Empty);
                dataGridViewSickPay.Columns.Add("Номер", "Номер");
                dataGridViewSickPay.Columns.Add("Сотрудник", "Сотрудник");
                dataGridViewSickPay.Columns.Add("Дата начала больничного", "Дата начала больничного");
                dataGridViewSickPay.Columns.Add("Дата конца больничного", "Дата конца больничного");
                dataGridViewSickPay.Columns.Add("Стаж работы", "Стаж работы");
                dataGridViewSickPay.Columns.Add("Средний дневной заработок", "Средний дневной заработок");
                dataGridViewSickPay.Columns.Add("Итого", "Итого");
                dataGridViewSickPay.Columns.Add("IsNew", String.Empty);
                HideIsNewColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// HideIsNewColumns() вызывается при прятании колонок
        /// </summary>
        private void HideIsNewColumns()
        {
            dataGridViewProjects.Columns["IsNew"].Visible = false;
            dataGridViewEmployees.Columns["IsNew"].Visible = false;
            dataGridViewSalaryAccruals.Columns["IsNew"].Visible = false;
            dataGridViewSalary.Columns["IsNew"].Visible = false;
            dataGridViewAccountingsOfWorkingHours.Columns["IsNew"].Visible = false;
            dataGridViewVacationPay.Columns["IsNew"].Visible = false;
            dataGridViewSickPay.Columns["IsNew"].Visible = false;
        }

        /// <summary>
        /// ClearFields() вызывается при очистке полей
        /// </summary>
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
                textBoxSalaryID.Text = "";
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
                textBoxHoursOfWork.Text = "";
                textBoxVacationPayID.Text = "";
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

        /// <summary>
        /// ReadSingleRow() вызывается при чтении каждой строки
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="iDataRecord"></param>
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
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.IsDBNull(2) ? "" : iDataRecord.GetDateTime(2).ToString("yyyy-MM-dd"), iDataRecord.GetString(3), iDataRecord.GetString(4), iDataRecord.GetString(5), iDataRecord.GetString(6), iDataRecord.IsDBNull(7) ? "" : iDataRecord.GetString(7), iDataRecord.IsDBNull(8) ? "" : iDataRecord.GetString(8), iDataRecord.IsDBNull(9) ? "" : iDataRecord.GetDateTime(9).ToString("yyyy-MM-dd"), iDataRecord.GetString(10), iDataRecord.GetString(11), RowState.Modified);
                        break;

                    case "dataGridViewSalaryAccruals":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetString(2), iDataRecord.GetString(3), RowState.Modified);
                        break;

                    case "dataGridViewSalary":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetInt32(1), iDataRecord.GetString(2), iDataRecord.GetInt32(3), iDataRecord.GetInt32(4), iDataRecord.GetDouble(5), iDataRecord.GetDouble(6), iDataRecord.GetDouble(7), iDataRecord.GetDouble(8), iDataRecord.GetDouble(9), iDataRecord.GetDouble(10), iDataRecord.GetDouble(11), RowState.Modified);
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetString(2), iDataRecord.GetString(3), iDataRecord.GetInt32(4), RowState.Modified);
                        break;

                    case "dataGridViewVacationPay":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetDateTime(2).ToString("yyyy-MM-dd"), iDataRecord.GetDateTime(3).ToString("yyyy-MM-dd"), iDataRecord.GetDouble(4), iDataRecord.GetDouble(5), RowState.Modified);
                        break;

                    case "dataGridViewSickPay":
                        dataGridView.Rows.Add(iDataRecord.GetInt32(0), iDataRecord.GetString(1), iDataRecord.GetDateTime(2).ToString("yyyy-MM-dd"), iDataRecord.GetDateTime(3).ToString("yyyy-MM-dd"), iDataRecord.GetInt32(4), iDataRecord.GetDouble(5), iDataRecord.GetDouble(6), RowState.Modified);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// RefreshDataGrid() вызывается при обновлении базы данных
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="tableName"></param>
        private void RefreshDataGrid(DataGridView dataGridView, string tableName)
        {
            try
            {
                dataGridView.Rows.Clear();
                string queryString = "";
                switch (tableName)
                {
                    case "Projects":
                        queryString = "SELECT * FROM Projects";
                        break;

                    case "Employees":
                        queryString = @"SELECT e.EmployeeID, e.FullName, e.BirthDate, e.BirthPlace,
                      e.PassportSeries, e.PassportNumber, e.Phone, e.Email, e.INN,
                      e.DateOfEmployment, p.Post AS PostName, g.Gender AS GenderName
                      FROM Employees e
                      LEFT JOIN Posts p ON e.PostID = p.PostID
                      LEFT JOIN Genders g ON e.GenderID = g.GenderID";
                        break;

                    case "SalaryAccruals":
                        queryString = @"SELECT sa.SalaryAccrualID, sa.Year, m.MonthName, p.ProjectName
                      FROM SalaryAccruals sa
                      LEFT JOIN Months m ON sa.MonthID = m.MonthID
                      LEFT JOIN Projects p ON sa.ProjectID = p.ProjectID";
                        break;

                    case "Salary":
                        queryString = @"SELECT s.SalaryID, s.SalaryAccrualID,
                          e.FullName AS EmployeeName,
                          s.AllDays, s.AllHours, s.PieceworkCharges,
                          s.HourlyCharges, s.VacationPay, s.SickPay,
                          s.PersonalIncomeTax, s.Contributions, s.Total
                   FROM Salary s
                   LEFT JOIN Employees e ON s.EmployeeID = e.EmployeeID";
                        break;

                    case "AccountingsOfWorkingHours":
                        queryString = @"SELECT a.AccountingOfWorkingHoursID, e.FullName AS EmployeeName,
                      p.ProjectName, tor.TypeOfRemuneration, a.HoursOfWork
                      FROM AccountingsOfWorkingHours a
                      LEFT JOIN Employees e ON a.EmployeeID = e.EmployeeID
                      LEFT JOIN Projects p ON a.ProjectID = p.ProjectID
                      LEFT JOIN TypesOfRemuneration tor ON a.TypeOfRemunerationID = tor.TypeOfRemunerationID";
                        break;

                    case "VacationPay":
                        queryString = @"SELECT v.VacationPayID, e.FullName AS EmployeeName,
                      v.VacationStartDate, v.VacationEndDate,
                      v.AverageDailyEarnings, v.Total
                      FROM VacationPay v
                      LEFT JOIN Employees e ON v.EmployeeID = e.EmployeeID";
                        break;

                    case "SickPay":
                        queryString = @"SELECT s.SickPayID, e.FullName AS EmployeeName,
                      s.SickStartDate, s.SickEndDate, s.Experience,
                      s.AverageDailyEarnings, s.Total
                      FROM SickPay s
                      LEFT JOIN Employees e ON s.EmployeeID = e.EmployeeID";
                        break;
                }
                SqlCommand sqlCommand = new(queryString, dataBase.GetConnection());
                dataBase.OpenConnection();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ReadSingleRow(dataGridView, sqlDataReader);
                }
                sqlDataReader.Close();
                FillAllComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// InitializeNotifyIcon() вызывается при инициализации уведомления
        /// </summary>
        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon
            {
                Icon = SystemIcons.Information,
                Visible = true
            };
        }

        /// <summary>
        /// InitializeTimer() вызывается при инициализации таймера
        /// </summary>
        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer
            {
                Interval = 3600000
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Timer_Tick() вызывается при прошествии таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowBalloonTip();
        }

        /// <summary>
        /// ShowBalloonTip() вызывается при показе уведомления
        /// </summary>
        private void ShowBalloonTip()
        {
            notifyIcon.BalloonTipTitle = "РусМитКонсерв";
            notifyIcon.BalloonTipText = $"Все права защищены.";
            notifyIcon.ShowBalloonTip(3000);
        }

        /// <summary>
        /// Form1_Load() вызывается при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// DataGridView_CellClick() вызывается при нажатии на ячейку
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="selectedRow"></param>
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
                        panelRecordProjects.Visible = true;
                        break;

                    case "dataGridViewEmployees":
                        textBoxEmployeeID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        textBoxFullName.Text = dataGridViewRow.Cells[1].Value.ToString();
                        dateTimePickerBirthDate.Text = dataGridViewRow.Cells[2].Value.ToString();
                        textBoxBirthPlace.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxPassportSeries.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxPassportNumber.Text = dataGridViewRow.Cells[5].Value.ToString();
                        maskedTextBoxPhone.Text = dataGridViewRow.Cells[6].Value.ToString();
                        textBoxEmail.Text = dataGridViewRow.Cells[7].Value.ToString();
                        textBoxINN.Text = dataGridViewRow.Cells[8].Value.ToString();
                        dateTimePickerDateOfEmployment.Text = dataGridViewRow.Cells[9].Value.ToString();
                        comboBoxPostID.Text = dataGridViewRow.Cells[10].Value.ToString();
                        comboBoxGenderID.Text = dataGridViewRow.Cells[11].Value.ToString();
                        panelRecordEmployees.Visible = true;
                        break;

                    case "dataGridViewSalaryAccruals":
                        textBoxSalaryAccrualID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        textBoxYear.Text = dataGridViewRow.Cells[1].Value.ToString();
                        comboBoxMonthID.Text = dataGridViewRow.Cells[2].Value.ToString();
                        comboBoxProjectIDSalaryAccruals.Text = dataGridViewRow.Cells[3].Value.ToString();
                        panelRecordSalaryAccruals.Visible = true;
                        break;

                    case "dataGridViewSalary":
                        textBoxSalaryID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        comboBoxSalaryAccrualIDSalary.Text = dataGridViewRow.Cells[1].Value.ToString();
                        comboBoxEmployeeIDSalary.Text = dataGridViewRow.Cells[2].Value.ToString();
                        textBoxAllDays.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxAllHours.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxPieceworkCharges.Text = dataGridViewRow.Cells[5].Value.ToString();
                        textBoxHourlyCharges.Text = dataGridViewRow.Cells[6].Value.ToString();
                        textBoxVacationPay.Text = dataGridViewRow.Cells[7].Value.ToString();
                        textBoxSickPay.Text = dataGridViewRow.Cells[8].Value.ToString();
                        textBoxPersonalIncomeTax.Text = dataGridViewRow.Cells[9].Value.ToString();
                        textBoxContributions.Text = dataGridViewRow.Cells[10].Value.ToString();
                        textBoxTotal.Text = dataGridViewRow.Cells[11].Value.ToString();
                        panelRecordSalary.Visible = true;
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        textBoxAccountingsOfWorkingHoursID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        comboBoxEmployeeIDAccountingsOfWorkingHours.Text = dataGridViewRow.Cells[1].Value.ToString();
                        comboBoxProjectIDAccountingsOfWorkingHours.Text = dataGridViewRow.Cells[2].Value.ToString();
                        comboBoxTypeOfRemunerationID.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxHoursOfWork.Text = dataGridViewRow.Cells[4].Value.ToString();
                        panelRecordAccountingsOfWorkingHours.Visible = true;
                        break;

                    case "dataGridViewVacationPay":
                        textBoxVacationPayID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        comboBoxEmployeeIDVacationPay.Text = dataGridViewRow.Cells[1].Value.ToString();
                        dateTimePickerVacationStartDate.Text = dataGridViewRow.Cells[2].Value.ToString();
                        dateTimePickerVacationEndDate.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxAverageDailyEarnings.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxTotalVacationPay.Text = dataGridViewRow.Cells[5].Value.ToString();
                        panelRecordVacationPay.Visible = true;
                        break;

                    case "dataGridViewSickPay":
                        textBoxSickPayID.Text = dataGridViewRow.Cells[0].Value.ToString();
                        comboBoxEmployeeIDSickPay.Text = dataGridViewRow.Cells[1].Value.ToString();
                        dateTimePickerSickStartDate.Text = dataGridViewRow.Cells[2].Value.ToString();
                        dateTimePickerSickEndDate.Text = dataGridViewRow.Cells[3].Value.ToString();
                        textBoxExperience.Text = dataGridViewRow.Cells[4].Value.ToString();
                        textBoxAverageDailyEarningsSickPay.Text = dataGridViewRow.Cells[5].Value.ToString();
                        textBoxTotalSickPay.Text = dataGridViewRow.Cells[6].Value.ToString();
                        panelRecordSickPay.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Search() вызывается при поиске
        /// </summary>
        /// <param name="dataGridView"></param>
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
                        string searchStringEmployees = $"select * from Employees where concat (EmployeeID, FullName, BirthDate, BirthPlace, PassportSeries, PassportNumber, Phone, Email, INN, DateOfEmployment, PostID, GenderID) like '%" + textBoxSearchEmployees.Text + "%'";
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

        /// <summary>
        /// DeleteRow() вызывается при удалении строки
        /// </summary>
        /// <param name="dataGridView"></param>
        private static void DeleteRow(DataGridView dataGridView)
        {
            try
            {
                DialogResult result = MessageBox.Show(
            "Вы уверены, что хотите удалить эту запись?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }
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
                            dataGridView.Rows[index].Cells[12].Value = RowState.Deleted;
                            return;
                        }
                        dataGridView.Rows[index].Cells[12].Value = RowState.Deleted;
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

        /// <summary>
        /// UpdateBase() вызывается при обновлении базы данных
        /// </summary>
        /// <param name="dataGridView"></param>
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
                                FillAllComboBoxes();
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
                                FillAllComboBoxes();
                            }
                            if (rowStateProjects == RowState.New)
                            {
                                var projectName = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var hourly = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var pieceWork = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var newQuery = $"insert into Projects (ProjectName, Hourly, PieceWork) values ('{projectName}', '{hourly}', '{pieceWork}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                                FillAllComboBoxes();
                            }
                            break;

                        case "dataGridViewEmployees":
                            var rowStateEmployees = (RowState)dataGridView.Rows[index].Cells[12].Value;
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
                                FillAllComboBoxes();
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
                                var postName = dataGridView.Rows[index].Cells[10].Value?.ToString();
                                string postIdValue = "NULL";
                                if (!string.IsNullOrEmpty(postName))
                                {
                                    var getPostIdQuery = $"SELECT PostID FROM Posts WHERE Post = '{postName}'";
                                    var postIdCommand = new SqlCommand(getPostIdQuery, dataBase.GetConnection());
                                    var result = postIdCommand.ExecuteScalar();
                                    postIdValue = result?.ToString() ?? "NULL";
                                }
                                var genderName = dataGridView.Rows[index].Cells[11].Value?.ToString();
                                string genderIdValue = "NULL";
                                if (!string.IsNullOrEmpty(genderName))
                                {
                                    var getGenderIdQuery = $"SELECT GenderID FROM Genders WHERE Gender = '{genderName}'";
                                    var genderIdCommand = new SqlCommand(getGenderIdQuery, dataBase.GetConnection());
                                    var result = genderIdCommand.ExecuteScalar();
                                    genderIdValue = result?.ToString() ?? "NULL";
                                }
                                var changeQuery = $"update Employees set FullName = '{fullName}', BirthDate = '{birthDate}', BirthPlace = '{birthPlace}', PassportSeries = '{passportSeries}', PassportNumber = '{passportNumber}', Phone = '{phone}', Email = '{email}', INN = '{iNN}', PostID = '{postIdValue}', GenderID = '{genderIdValue}' where EmployeeID = '{employeeID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                                FillAllComboBoxes();
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
                                var postName = dataGridView.Rows[index].Cells[10].Value?.ToString();
                                string postIdValue = "NULL";
                                if (!string.IsNullOrEmpty(postName))
                                {
                                    var getPostIdQuery = $"SELECT PostID FROM Posts WHERE Post = '{postName}'";
                                    var postIdCommand = new SqlCommand(getPostIdQuery, dataBase.GetConnection());
                                    var result = postIdCommand.ExecuteScalar();
                                    postIdValue = result?.ToString() ?? "NULL";
                                }
                                var genderName = dataGridView.Rows[index].Cells[11].Value?.ToString();
                                string genderIdValue = "NULL";
                                if (!string.IsNullOrEmpty(genderName))
                                {
                                    var getGenderIdQuery = $"SELECT GenderID FROM Genders WHERE Gender = '{genderName}'";
                                    var genderIdCommand = new SqlCommand(getGenderIdQuery, dataBase.GetConnection());
                                    var result = genderIdCommand.ExecuteScalar();
                                    genderIdValue = result?.ToString() ?? "NULL";
                                }
                                var newQuery = $"insert into Employees (FullName, BirthDate, BirthPlace, PassportSeries, PassportNumber, Phone, Email, INN, PostID, GenderID) values ('{fullName}', '{birthDate}', '{birthPlace}', '{passportSeries}', '{passportNumber}', '{phone}', '{email}', '{iNN}', '{postIdValue}', '{genderIdValue}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                                FillAllComboBoxes();
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
                                FillAllComboBoxes();
                            }
                            if (rowStateSalaryAccruals == RowState.Modified)
                            {
                                var salaryAccrualID = dataGridView.Rows[index].Cells[0].Value.ToString();
                                var year = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var monthName = dataGridView.Rows[index].Cells[2].Value?.ToString();
                                string monthIdValue = "NULL";
                                if (!string.IsNullOrEmpty(monthName))
                                {
                                    var getMonthIdQuery = $"SELECT MonthID FROM Months WHERE MonthName = '{monthName}'";
                                    var monthIdCommand = new SqlCommand(getMonthIdQuery, dataBase.GetConnection());
                                    var result = monthIdCommand.ExecuteScalar();
                                    monthIdValue = result?.ToString() ?? "NULL";
                                }
                                var projectName = dataGridView.Rows[index].Cells[3].Value?.ToString();
                                string projectIdValue = "NULL";
                                if (!string.IsNullOrEmpty(projectName))
                                {
                                    var getProjectIdQuery = $"SELECT ProjectID FROM Projects WHERE ProjectName = '{projectName}'";
                                    var projectIdCommand = new SqlCommand(getProjectIdQuery, dataBase.GetConnection());
                                    var result = projectIdCommand.ExecuteScalar();
                                    projectIdValue = result?.ToString() ?? "NULL";
                                }
                                var changeQuery = $"update SalaryAccruals set Year = '{year}', MonthID = '{monthIdValue}', ProjectID = '{projectIdValue}' where SalaryAccrualID = '{salaryAccrualID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                                FillAllComboBoxes();
                            }
                            if (rowStateSalaryAccruals == RowState.New)
                            {
                                var year = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var monthName = dataGridView.Rows[index].Cells[2].Value?.ToString();
                                string monthIdValue = "NULL";
                                if (!string.IsNullOrEmpty(monthName))
                                {
                                    var getMonthIdQuery = $"SELECT MonthID FROM Months WHERE MonthName = '{monthName}'";
                                    var monthIdCommand = new SqlCommand(getMonthIdQuery, dataBase.GetConnection());
                                    var result = monthIdCommand.ExecuteScalar();
                                    monthIdValue = result?.ToString() ?? "NULL";
                                }
                                var projectName = dataGridView.Rows[index].Cells[3].Value?.ToString();
                                string projectIdValue = "NULL";
                                if (!string.IsNullOrEmpty(projectName))
                                {
                                    var getProjectIdQuery = $"SELECT ProjectID FROM Projects WHERE ProjectName = '{projectName}'";
                                    var projectIdCommand = new SqlCommand(getProjectIdQuery, dataBase.GetConnection());
                                    var result = projectIdCommand.ExecuteScalar();
                                    projectIdValue = result?.ToString() ?? "NULL";
                                }
                                var newQuery = $"insert into SalaryAccruals (Year, MonthID, ProjectID) values ('{year}', '{monthIdValue}', '{projectIdValue}')";
                                var sqlCommand = new SqlCommand(newQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                                FillAllComboBoxes();
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
                                var employeeName = dataGridView.Rows[index].Cells[2].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var changeQuery = $"update Salary set SalaryAccrualID = '{salaryAccrualID}', EmployeeID = '{employeeIdValue}' where SalaryID = '{salaryID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSalary == RowState.New)
                            {
                                var salaryAccrualID = dataGridView.Rows[index].Cells[1].Value.ToString();
                                var employeeName = dataGridView.Rows[index].Cells[2].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var newQuery = $"insert into Salary (SalaryAccrualID, EmployeeID) values ('{salaryAccrualID}', '{employeeIdValue}')";
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
                                var employeeName = dataGridView.Rows[index].Cells[1].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var projectName = dataGridView.Rows[index].Cells[2].Value?.ToString();
                                string projectIdValue = "NULL";
                                if (!string.IsNullOrEmpty(projectName))
                                {
                                    var getProjectIdQuery = $"SELECT ProjectID FROM Projects WHERE ProjectName = '{projectName}'";
                                    var projectIdCommand = new SqlCommand(getProjectIdQuery, dataBase.GetConnection());
                                    var result = projectIdCommand.ExecuteScalar();
                                    projectIdValue = result?.ToString() ?? "NULL";
                                }
                                var typeName = dataGridView.Rows[index].Cells[3].Value?.ToString();
                                string typeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(typeName))
                                {
                                    var getTypeIdQuery = $"SELECT TypeOfRemunerationID FROM TypesOfRemuneration WHERE TypeOfRemuneration = '{typeName}'";
                                    var typeIdCommand = new SqlCommand(getTypeIdQuery, dataBase.GetConnection());
                                    var result = typeIdCommand.ExecuteScalar();
                                    typeIdValue = result?.ToString() ?? "NULL";
                                }
                                var hoursOfWork = dataGridView.Rows[index].Cells[4].Value.ToString();
                                var changeQuery = $"update AccountingsOfWorkingHours set EmployeeID = '{employeeIdValue}', ProjectID = '{projectIdValue}', TypeOfRemunerationID = '{typeIdValue}', HoursOfWork = '{hoursOfWork}' where AccountingOfWorkingHoursID = '{accountingOfWorkingHoursID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateAccountingsOfWorkingHours == RowState.New)
                            {
                                var employeeName = dataGridView.Rows[index].Cells[1].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var projectName = dataGridView.Rows[index].Cells[2].Value?.ToString();
                                string projectIdValue = "NULL";
                                if (!string.IsNullOrEmpty(projectName))
                                {
                                    var getProjectIdQuery = $"SELECT ProjectID FROM Projects WHERE ProjectName = '{projectName}'";
                                    var projectIdCommand = new SqlCommand(getProjectIdQuery, dataBase.GetConnection());
                                    var result = projectIdCommand.ExecuteScalar();
                                    projectIdValue = result?.ToString() ?? "NULL";
                                }
                                var typeName = dataGridView.Rows[index].Cells[3].Value?.ToString();
                                string typeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(typeName))
                                {
                                    var getTypeIdQuery = $"SELECT TypeOfRemunerationID FROM TypesOfRemuneration WHERE TypeOfRemuneration = '{typeName}'";
                                    var typeIdCommand = new SqlCommand(getTypeIdQuery, dataBase.GetConnection());
                                    var result = typeIdCommand.ExecuteScalar();
                                    typeIdValue = result?.ToString() ?? "NULL";
                                }
                                var hoursOfWork = dataGridView.Rows[index].Cells[4].Value.ToString();
                                var newQuery = $"insert into AccountingsOfWorkingHours (EmployeeID, ProjectID, TypeOfRemunerationID, HoursOfWork) values ('{employeeIdValue}', '{projectIdValue}', '{typeIdValue}', '{hoursOfWork}')";
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
                                var employeeName = dataGridView.Rows[index].Cells[1].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var vacationStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var vacationEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var changeQuery = $"update VacationPay set EmployeeID = '{employeeIdValue}', VacationStartDate = '{vacationStartDate}', VacationEndDate = '{vacationEndDate}' where VacationPayID = '{vacationPayID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateVacationPay == RowState.New)
                            {
                                var employeeName = dataGridView.Rows[index].Cells[1].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var vacationStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var vacationEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var newQuery = $"insert into VacationPay (EmployeeID, VacationStartDate, VacationEndDate) values ('{employeeIdValue}', '{vacationStartDate}', '{vacationEndDate}')";
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
                                var employeeName = dataGridView.Rows[index].Cells[1].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var sickStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var sickEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var changeQuery = $"update SickPay set EmployeeID = '{employeeIdValue}', SickStartDate = '{sickStartDate}', SickEndDate = '{sickEndDate}' where SickPayID = '{sickPayID}'";
                                var sqlCommand = new SqlCommand(changeQuery, dataBase.GetConnection());
                                sqlCommand.ExecuteNonQuery();
                            }
                            if (rowStateSickPay == RowState.New)
                            {
                                var employeeName = dataGridView.Rows[index].Cells[1].Value?.ToString();
                                string employeeIdValue = "NULL";
                                if (!string.IsNullOrEmpty(employeeName))
                                {
                                    var getEmployeeIdQuery = $"SELECT EmployeeID FROM Employees WHERE FullName = '{employeeName}'";
                                    var employeeIdCommand = new SqlCommand(getEmployeeIdQuery, dataBase.GetConnection());
                                    var result = employeeIdCommand.ExecuteScalar();
                                    employeeIdValue = result?.ToString() ?? "NULL";
                                }
                                var sickStartDate = dataGridView.Rows[index].Cells[2].Value.ToString();
                                var sickEndDate = dataGridView.Rows[index].Cells[3].Value.ToString();
                                var newQuery = $"insert into SickPay (EmployeeID, SickStartDate, SickEndDate) values ('{employeeIdValue}', '{sickStartDate}', '{sickEndDate}')";
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

        /// <summary>
        /// Change() вызывается при изменении базы данных
        /// </summary>
        /// <param name="dataGridView"></param>
        private void Change(DataGridView dataGridView)
        {
            try
            {
                var selectedRowIndex = dataGridView.CurrentCell.RowIndex;
                switch (dataGridView.Name)
                {
                    case "dataGridViewProjects":
                        var projectID = textBoxProjectID.Text;
                        var projectName = textBoxProjectName.Text;
                        var hourly = textBoxHourly.Text;
                        var pieceWork = textBoxPieceWork.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(projectID, projectName, hourly, pieceWork);
                        dataGridView.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                        break;

                    case "dataGridViewEmployees":
                        var employeeID = textBoxEmployeeID.Text;
                        var fullName = textBoxFullName.Text;
                        var birthDate = dateTimePickerBirthDate.Value;
                        var birthPlace = textBoxBirthPlace.Text;
                        var passportSeries = textBoxPassportSeries.Text;
                        var passportNumber = textBoxPassportNumber.Text;
                        var phone = maskedTextBoxPhone.Text;
                        var email = textBoxEmail.Text;
                        var iNN = textBoxINN.Text;
                        var dateOfEmployment = dateTimePickerDateOfEmployment.Value;
                        var postID = comboBoxPostID.Text;
                        var genderID = comboBoxGenderID.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(employeeID, fullName, birthDate, birthPlace, passportSeries, passportNumber, phone, email, iNN, dateOfEmployment, postID, genderID);
                        dataGridView.Rows[selectedRowIndex].Cells[12].Value = RowState.Modified;
                        break;

                    case "dataGridViewSalaryAccruals":
                        var salaryAccrualID = textBoxSalaryAccrualID.Text;
                        var year = textBoxYear.Text;
                        var monthID = comboBoxMonthID.Text;
                        var projectIDSalaryAccruals = comboBoxProjectIDSalaryAccruals.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(salaryAccrualID, year, monthID, projectIDSalaryAccruals);
                        dataGridView.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
                        break;

                    case "dataGridViewSalary":
                        var salaryID = textBoxSalaryID.Text;
                        var salaryAccrualIDSalary = comboBoxSalaryAccrualIDSalary.Text;
                        var employeeIDSalary = comboBoxEmployeeIDSalary.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(salaryID, salaryAccrualIDSalary, employeeIDSalary);
                        dataGridView.Rows[selectedRowIndex].Cells[12].Value = RowState.Modified;
                        break;

                    case "dataGridViewAccountingsOfWorkingHours":
                        var accountingOfWorkingHoursID = textBoxAccountingsOfWorkingHoursID.Text;
                        var employeeIDAccountingsOfWorkingHours = comboBoxEmployeeIDAccountingsOfWorkingHours.Text;
                        var projectIDAccountingsOfWorkingHours = comboBoxProjectIDAccountingsOfWorkingHours.Text;
                        var typeOfRemunerationID = comboBoxTypeOfRemunerationID.Text;
                        var hoursOfWork = textBoxHoursOfWork.Text;
                        dataGridView.Rows[selectedRowIndex].SetValues(accountingOfWorkingHoursID, employeeIDAccountingsOfWorkingHours, projectIDAccountingsOfWorkingHours, typeOfRemunerationID, hoursOfWork);
                        dataGridView.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                        break;

                    case "dataGridViewVacationPay":
                        var vacationPayID = textBoxVacationPayID.Text;
                        var employeeIDVacationPay = comboBoxEmployeeIDVacationPay.Text;
                        var vacationStartDate = dateTimePickerVacationStartDate.Value;
                        var vacationEndDate = dateTimePickerVacationEndDate.Value;
                        dataGridView.Rows[selectedRowIndex].SetValues(vacationPayID, employeeIDVacationPay, vacationStartDate, vacationEndDate);
                        dataGridView.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                        break;

                    case "dataGridViewSickPay":
                        var sickPayID = textBoxSickPayID.Text;
                        var employeeIDSickPay = comboBoxEmployeeIDSickPay.Text;
                        var sickStartDate = dateTimePickerSickStartDate.Value;
                        var sickEndDate = dateTimePickerSickEndDate.Value;
                        dataGridView.Rows[selectedRowIndex].SetValues(sickPayID, employeeIDSickPay, sickStartDate, sickEndDate);
                        dataGridView.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ExportToWord() вызывается при экспорте в Word
        /// </summary>
        /// <param name="dataGridView"></param>
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

        /// <summary>
        /// ExportToExcel() вызывается при экспорте в Excel
        /// </summary>
        /// <param name="dataGridView"></param>
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

        /// <summary>
        /// Reports() вызывается при формировании отчетов
        /// </summary>
        /// <param name="report"></param>
        private void Reports(string report)
        {
            dataBase.OpenConnection();
            var wordApp = new Application { Visible = true };
            Document doc = wordApp.Documents.Add();
            Paragraph title = doc.Paragraphs.Add();
            string query = "";
            switch (report)
            {
                case "SalaryAccruals":
                    title.Range.Text = "Отчёт по начислению зарплат сотрудников за месяц";
                    query = @"SELECT
                                s.SalaryID,
                                e.FullName,
                                m.MonthName,
                                s.AllDays,
                                s.AllHours,
                                s.PieceworkCharges,
                                s.HourlyCharges,
                                s.VacationPay,
                                s.SickPay,
                                s.PersonalIncomeTax,
                                s.Contributions,
                                s.Total
                            FROM Salary s
                            JOIN Employees e ON s.EmployeeID = e.EmployeeID
                            JOIN SalaryAccruals sa ON s.SalaryAccrualID = sa.SalaryAccrualID
                            JOIN Months m ON sa.MonthID = m.MonthID
                            ORDER BY sa.Year DESC, m.MonthID DESC, e.FullName;"
                    ;
                    break;

                case "AccountingsOfWorkingHours":
                    title.Range.Text = "Отчёт по отработанным часам сотрудников за период";
                    query = @"SELECT
                                e.FullName,
                                p.ProjectName,
                                t.TypeOfRemuneration,
                                SUM(a.HoursOfWork) AS TotalHoursWorked
                            FROM AccountingsOfWorkingHours a
                            JOIN Employees e ON a.EmployeeID = e.EmployeeID
                            JOIN Projects p ON a.ProjectID = p.ProjectID
                            JOIN TypesOfRemuneration t ON a.TypeOfRemunerationID = t.TypeOfRemunerationID
                            GROUP BY e.FullName, p.ProjectName, t.TypeOfRemuneration
                            ORDER BY e.FullName, p.ProjectName;"
                    ;
                    break;

                case "Vacation":
                    title.Range.Text = "Отчёт по отпускным и больничным выплатам";
                    query = @"SELECT
                                e.FullName,
                                v.VacationStartDate,
                                v.VacationEndDate,
                                v.Total AS VacationTotal,
                                s.SickStartDate,
                                s.SickEndDate,
                                s.Experience,
                                s.Total AS SickTotal
                            FROM Employees e
                            LEFT JOIN VacationPay v ON e.EmployeeID = v.EmployeeID
                            LEFT JOIN SickPay s ON e.EmployeeID = s.EmployeeID
                            ORDER BY e.FullName;"
                    ;
                    break;
            }
            SqlCommand command = new(query, dataBase.GetConnection());
            SqlDataAdapter adapter = new(command);
            System.Data.DataTable dataTable = new();
            adapter.Fill(dataTable);
            dataBase.CloseConnection();
            title.Range.Font.Bold = 1;
            title.Range.Font.Size = 14;
            title.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.InsertParagraphAfter();
            Table table = doc.Tables.Add(title.Range, dataTable.Rows.Count + 1, dataTable.Columns.Count);
            table.Borders.Enable = 1;
            for (int col = 0; col < dataTable.Columns.Count; col++)
            {
                table.Cell(1, col + 1).Range.Text = dataTable.Columns[col].ColumnName;
            }
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    table.Cell(row + 2, col + 1).Range.Text = dataTable.Rows[row][col].ToString();
                }
            }
        }

        /// <summary>
        /// FillAllComboBoxes() Заполняет все внешние ключи
        /// </summary>
        private void FillAllComboBoxes()
        {
            try
            {
                dataBase.OpenConnection();
                comboBoxPostID.Items.Clear();
                var postsQuery = "SELECT Post FROM Posts ORDER BY Post";
                var postsCommand = new SqlCommand(postsQuery, dataBase.GetConnection());
                var postsReader = postsCommand.ExecuteReader();
                while (postsReader.Read())
                {
                    comboBoxPostID.Items.Add(postsReader.GetString(0));
                }
                postsReader.Close();
                comboBoxGenderID.Items.Clear();
                var gendersQuery = "SELECT Gender FROM Genders ORDER BY Gender";
                var gendersCommand = new SqlCommand(gendersQuery, dataBase.GetConnection());
                var gendersReader = gendersCommand.ExecuteReader();
                while (gendersReader.Read())
                {
                    comboBoxGenderID.Items.Add(gendersReader.GetString(0));
                }
                gendersReader.Close();
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
                comboBoxSalaryAccrualIDSalary.Items.Clear();
                var salaryAccrualsQuery = "SELECT SalaryAccrualID FROM SalaryAccruals ORDER BY SalaryAccrualID";
                var salaryAccrualsCommand = new SqlCommand(salaryAccrualsQuery, dataBase.GetConnection());
                var salaryAccrualsReader = salaryAccrualsCommand.ExecuteReader();
                while (salaryAccrualsReader.Read())
                {
                    comboBoxSalaryAccrualIDSalary.Items.Add(salaryAccrualsReader.GetInt32(0));
                }
                salaryAccrualsReader.Close();
                comboBoxEmployeeIDSalary.Items.Clear();
                comboBoxEmployeeIDAccountingsOfWorkingHours.Items.Clear();
                comboBoxEmployeeIDVacationPay.Items.Clear();
                comboBoxEmployeeIDSickPay.Items.Clear();
                var employeesQuery = "SELECT FullName FROM Employees ORDER BY FullName";
                var employeesCommand = new SqlCommand(employeesQuery, dataBase.GetConnection());
                var employeesReader = employeesCommand.ExecuteReader();
                while (employeesReader.Read())
                {
                    string employeeName = employeesReader.GetString(0);
                    comboBoxEmployeeIDSalary.Items.Add(employeeName);
                    comboBoxEmployeeIDAccountingsOfWorkingHours.Items.Add(employeeName);
                    comboBoxEmployeeIDVacationPay.Items.Add(employeeName);
                    comboBoxEmployeeIDSickPay.Items.Add(employeeName);
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных в комбобоксы: {ex.Message}");
            }
        }

        /// <summary>
        /// ButtonRefresh_Click() вызывается при нажатии на кнопку обновления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// ButtonClear_Click() вызывается при нажатии на кнопку очистки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// ButtonNewProject_Click() вызывается при нажатии на кнопку "Новая запись" на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewProject_Click(object sender, EventArgs e)
        {
            try
            {
                AddFormProjects addForm = new();
                addForm.Show();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonNewEmployee_Click() вызывается при нажатии на кнопку "Новая запись" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                AddFormEmployees addForm = new();
                addForm.Show();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonNewSalaryAccrual_Click() вызывается при нажатии на кнопку "Новая запись" на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewSalaryAccrual_Click(object sender, EventArgs e)
        {
            try
            {
                AddFormSalaryAccruals addForm = new();
                addForm.Show();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonNewSalary_Click() вызывается при нажатии на кнопку "Новая запись" на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewSalary_Click(object sender, EventArgs e)
        {
            try
            {
                AddFormSalary addForm = new();
                addForm.Show();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonNewAccountingOfWorkingHours_Click() вызывается при нажатии на кнопку "Новая запись" на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
            try
            {
                AddFormAccountingsOfWorkingHours addForm = new();
                addForm.Show();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonNewVacationPay_Click() вызывается при нажатии на кнопку "Новая запись" на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewVacationPay_Click(object sender, EventArgs e)
        {
            try
            {
                AddFormVacationPay addForm = new();
                addForm.Show();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonNewSickPay_Click() вызывается при нажатии на кнопку "Новая запись" на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNewSickPay_Click(object sender, EventArgs e)
        {
            try
            {
                AddFormSickPay addForm = new();
                addForm.Show();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonDeleteProject_Click() вызывается при нажатии на кнопку "Удалить" на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteProject_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRow(dataGridViewProjects);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonDeleteEmployee_Click() вызывается при нажатии на кнопку "Удалить" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRow(dataGridViewEmployees);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonDeleteSalaryAccrual_Click() вызывается при нажатии на кнопку "Удалить" на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteSalaryAccrual_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRow(dataGridViewSalaryAccruals);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonDeleteSalary_Click() вызывается при нажатии на кнопку "Удалить" на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteSalary_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRow(dataGridViewSalary);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonDeleteAccountingOfWorkingHours_Click() вызывается при нажатии на кнопку "Удалить" на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRow(dataGridViewAccountingsOfWorkingHours);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonDeleteVacationPay_Click() вызывается при нажатии на кнопку "Удалить" на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteVacationPay_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRow(dataGridViewVacationPay);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonDeleteSickPay_Click() вызывается при нажатии на кнопку "Удалить" на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteSickPay_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteRow(dataGridViewSickPay);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonChangeProject_Click() вызывается при нажатии на кнопку "Изменить" на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeProject_Click(object sender, EventArgs e)
        {
            try
            {
                Change(dataGridViewProjects);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonChangeEmployee_Click() вызывается при нажатии на кнопку "Изменить" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Change(dataGridViewEmployees);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonChangeSalaryAccrual_Click() вызывается при нажатии на кнопку "Изменить" на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeSalaryAccrual_Click(object sender, EventArgs e)
        {
            try
            {
                Change(dataGridViewSalaryAccruals);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonChangeSalary_Click() вызывается при нажатии на кнопку "Изменить" на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeSalary_Click(object sender, EventArgs e)
        {
            try
            {
                Change(dataGridViewSalary);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonChangeAccountingOfWorkingHours_Click() вызывается при нажатии на кнопку "Изменить" на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
            try
            {
                Change(dataGridViewAccountingsOfWorkingHours);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonChangeVacationPay_Click() вызывается при нажатии на кнопку "Изменить" на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeVacationPay_Click(object sender, EventArgs e)
        {
            try
            {
                Change(dataGridViewVacationPay);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonChangeSickPay_Click() вызывается при нажатии на кнопку "Изменить" на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonChangeSickPay_Click(object sender, EventArgs e)
        {
            try
            {
                Change(dataGridViewSickPay);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonSaveProject_Click() вызывается при нажатии на кнопку "Сохранить" на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin)
                {
                    UpdateBase(dataGridViewProjects);
                }
                else
                {
                    MessageBox.Show("У вас недостаточно прав!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonSaveEmployee_Click() вызывается при нажатии на кнопку "Сохранить" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin)
                {
                    UpdateBase(dataGridViewEmployees);
                }
                else
                {
                    MessageBox.Show("У вас недостаточно прав!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonSaveSalaryAccrual_Click() вызывается при нажатии на кнопку "Сохранить" на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSalaryAccrual_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin)
                {
                    UpdateBase(dataGridViewSalaryAccruals);
                }
                else
                {
                    MessageBox.Show("У вас недостаточно прав!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonSaveSalary_Click() вызывается при нажатии на кнопку "Сохранить" на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSalary_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBase(dataGridViewSalary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonSaveAccountingOfWorkingHours_Click() вызывается при нажатии на кнопку "Сохранить" на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBase(dataGridViewAccountingsOfWorkingHours);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonSaveVacationPay_Click() вызывается при нажатии на кнопку "Сохранить" на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveVacationPay_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBase(dataGridViewVacationPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonSaveSickPay_Click() вызывается при нажатии на кнопку "Сохранить" на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveSickPay_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBase(dataGridViewSickPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordProject_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// ButtonWordEmployee_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewEmployees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordSalaryAccrual_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordSalaryAccrual_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewSalaryAccruals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordSalary_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordSalary_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewSalary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordAccountingOfWorkingHours_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewAccountingsOfWorkingHours);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordVacationPay_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordVacationPay_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewVacationPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonWordSickPay_Click() вызывается при нажатии на кнопку "Вывод в Word" на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonWordSickPay_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToWord(dataGridViewSickPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelProject_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// ButtonExcelEmployee_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewEmployees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelSalaryAccrual_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelSalaryAccrual_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewSalaryAccruals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelSalary_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelSalary_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewSalary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelAccountingOfWorkingHours_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelAccountingOfWorkingHours_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewAccountingsOfWorkingHours);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelVacationPay_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelVacationPay_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewVacationPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonExcelSickPay_Click() вызывается при нажатии на кнопку "Вывод в Excel" на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExcelSickPay_Click(object sender, EventArgs e)
        {
            try
            {
                ExportToExcel(dataGridViewSickPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataGridViewProjects_CellClick() вызывается при нажатии на ячейку на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridView_CellClick(dataGridViewProjects, selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataGridViewEmployees_CellClick() вызывается при нажатии на ячейку на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridView_CellClick(dataGridViewEmployees, selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataGridViewSalaryAccruals_CellClick() вызывается при нажатии на ячейку на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSalaryAccruals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridView_CellClick(dataGridViewSalaryAccruals, selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataGridViewSalary_CellClick() вызывается при нажатии на ячейку на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridView_CellClick(dataGridViewSalary, selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataGridViewAccountingsOfWorkingHours_CellClick() вызывается при нажатии на ячейку на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewAccountingsOfWorkingHours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridView_CellClick(dataGridViewAccountingsOfWorkingHours, selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataGridViewVacationPay_CellClick() вызывается при нажатии на ячейку на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewVacationPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridView_CellClick(dataGridViewVacationPay, selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// DataGridViewSickPay_CellClick() вызывается при нажатии на ячейку на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSickPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRow = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    DataGridView_CellClick(dataGridViewSickPay, selectedRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextBoxSearchProjects_TextChanged() вызывается при изменении текста на вкладке "Проекты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchProjects_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(dataGridViewProjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextBoxSearchEmployees_TextChanged() вызывается при изменении текста на вкладке "Сотрудники"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchEmployees_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(dataGridViewEmployees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextBoxSearchSalaryAccruals_TextChanged() вызывается при изменении текста на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchSalaryAccruals_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(dataGridViewSalaryAccruals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextBoxSearchSalary_TextChanged() вызывается при изменении текста на вкладке "Выплаты зарплат"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchSalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(dataGridViewSalary);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextBoxSearchAccountingsOfWorkingHours_TextChanged() вызывается при изменении текста на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchAccountingsOfWorkingHours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(dataGridViewAccountingsOfWorkingHours);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextBoxSearchVacationPay_TextChanged() вызывается при изменении текста на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchVacationPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(dataGridViewVacationPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TextBoxSearchSickPay_TextChanged() вызывается при изменении текста на вкладке "Больничные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSearchSickPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Search(dataGridViewSickPay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ButtonReportSalaryAccruals_Click() вызывается при нажатии на кнопку отчета на вкладке "Зарплаты"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReportSalaryAccruals_Click(object sender, EventArgs e)
        {
            Reports("SalaryAccruals");
        }

        /// <summary>
        /// ButtonReportAccountingsOfWorkingHours_Click() вызывается при нажатии на кнопку отчета на вкладке "Учет времени"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReportAccountingsOfWorkingHours_Click(object sender, EventArgs e)
        {
            Reports("AccountingsOfWorkingHours");
        }

        /// <summary>
        /// ButtonReportVacationPay_Click() вызывается при нажатии на кнопку отчета на вкладке "Отпускные"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReportVacationPay_Click(object sender, EventArgs e)
        {
            Reports("VacationPay");
        }
    }
}