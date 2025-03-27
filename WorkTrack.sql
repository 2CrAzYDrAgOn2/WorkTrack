CREATE DATABASE WorkTrack;
USE WorkTrack;

CREATE TABLE Genders(
	GenderID INT PRIMARY KEY IDENTITY(1,1),
	Gender NVARCHAR(150) NOT NULL
);

CREATE TABLE Posts(
	PostID INT PRIMARY KEY IDENTITY(1,1),
	Post NVARCHAR(150) NOT NULL
);

CREATE TABLE TypesOfRemuneration(
	TypeOfRemunerationID INT PRIMARY KEY IDENTITY(1,1),
	TypeOfRemuneration NVARCHAR(150) NOT NULL
);

CREATE TABLE Months(
	MonthID INT PRIMARY KEY IDENTITY(1,1),
	MonthName NVARCHAR(150) NOT NULL,
	WorkingHours INT NOT NULL DEFAULT 0
);

CREATE TABLE Projects(
	ProjectID INT PRIMARY KEY IDENTITY(1,1),
	ProjectName NVARCHAR(150) NOT NULL,
	Hourly FLOAT NOT NULL,
	PieceWork FLOAT NOT NULL
);

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(150) NOT NULL,
	BirthDate DATE,
	BirthPlace NVARCHAR(150),
	PassportSeries NVARCHAR(4) CHECK (PassportSeries LIKE '[0-9][0-9][0-9][0-9]'),
	PassportNumber NVARCHAR(6) CHECK (PassportNumber LIKE '[0-9][0-9][0-9][0-9][0-9][0-9]'),
    Phone NVARCHAR(18) UNIQUE NOT NULL,
    Email NVARCHAR(100) UNIQUE,
	INN NVARCHAR(12) UNIQUE,
	DateOfEmployment DATE DEFAULT GETDATE(),
	PostID INT DEFAULT 0,
	GenderID INT DEFAULT 0,
	FOREIGN KEY (GenderID) REFERENCES Genders(GenderID),
	FOREIGN KEY (PostID) REFERENCES Posts(PostID)
);

CREATE TABLE SalaryAccruals (
	SalaryAccrualID INT PRIMARY KEY IDENTITY(1,1),
	Year INT,
	MonthID INT,
	ProjectID INT,
	FOREIGN KEY (MonthID) REFERENCES Months(MonthID) ON DELETE CASCADE,
	FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID) ON DELETE CASCADE
);

CREATE TABLE Salary(
	SalaryID INT PRIMARY KEY IDENTITY(1,1),
	SalaryAccrualID INT,
	EmployeeID INT,
	AllDays INT DEFAULT 0,
	AllHours INT DEFAULT 0,
	PieceworkCharges FLOAT DEFAULT 0,
	HourlyCharges FLOAT DEFAULT 0,
	VacationPay FLOAT DEFAULT 0,
	SickPay FLOAT DEFAULT 0,
	PersonalIncomeTax FLOAT DEFAULT 0,
	Contributions FLOAT DEFAULT 0,
	Total AS (
		(PieceworkCharges + HourlyCharges + VacationPay + SickPay) 
		- (PersonalIncomeTax + Contributions)
	),
	FOREIGN KEY (SalaryAccrualID) REFERENCES SalaryAccruals(SalaryAccrualID) ON DELETE CASCADE,
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE
);

CREATE TABLE AccountingsOfWorkingHours(
	AccountingOfWorkingHoursID INT PRIMARY KEY IDENTITY(1,1),
	EmployeeID INT,
	ProjectID INT,
	TypeOfRemunerationID INT,
	HoursOfWork INT,
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE,
	FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID),
	FOREIGN KEY (TypeOfRemunerationID) REFERENCES TypesOfRemuneration(TypeOfRemunerationID)
);

CREATE TABLE VacationPay(
	VacationPayID INT PRIMARY KEY IDENTITY(1,1),
	EmployeeID INT,
	VacationStartDate DATETIME,
	VacationEndDate DATETIME DEFAULT GETDATE(),
	AverageDailyEarnings FLOAT CHECK (AverageDailyEarnings >= 0) DEFAULT 0,
	Total AS (
		(DATEDIFF(DAY, VacationStartDate, VacationEndDate) + 1) * AverageDailyEarnings
	),
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE
);

CREATE TABLE SickPay(
	SickPayID INT PRIMARY KEY IDENTITY(1,1),
	EmployeeID INT,
	SickStartDate DATETIME,
	SickEndDate DATETIME DEFAULT GETDATE(),
	Experience INT DEFAULT 0,
	AverageDailyEarnings FLOAT CHECK (AverageDailyEarnings >= 0) DEFAULT 0,
	Total AS (
		(DATEDIFF(DAY, SickStartDate, SickEndDate) + 1) * AverageDailyEarnings
	),
	FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE
);

CREATE TABLE Registration (
    RegistrationID INT PRIMARY KEY IDENTITY(1,1),
    UserLogin NVARCHAR(50) NOT NULL,
    UserPassword NVARCHAR(50) NOT NULL,
	IsAdmin BIT DEFAULT 0
);


CREATE TRIGGER trg_UpdateSalary
ON AccountingsOfWorkingHours
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE s
    SET 
        AllDays = (SELECT COUNT(DISTINCT awh.HoursOfWork / 8) FROM AccountingsOfWorkingHours awh WHERE awh.EmployeeID = s.EmployeeID),
        AllHours = (SELECT SUM(awh.HoursOfWork) FROM AccountingsOfWorkingHours awh WHERE awh.EmployeeID = s.EmployeeID)
    FROM Salary s
    WHERE EXISTS (SELECT 1 FROM AccountingsOfWorkingHours awh WHERE awh.EmployeeID = s.EmployeeID);
END;

CREATE TRIGGER trg_CalculateSalaryAndComponents
ON AccountingsOfWorkingHours
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE s
    SET 
        PieceworkCharges = ROUND(ISNULL((
            SELECT SUM(p.PieceWork * awh.HoursOfWork) 
            FROM AccountingsOfWorkingHours awh 
            JOIN Projects p ON awh.ProjectID = p.ProjectID 
            WHERE awh.EmployeeID = s.EmployeeID
        ), 0), 2),
        HourlyCharges = ROUND(ISNULL(( 
            SELECT SUM(p.Hourly * awh.HoursOfWork) 
            FROM AccountingsOfWorkingHours awh 
            JOIN Projects p ON awh.ProjectID = p.ProjectID 
            WHERE awh.EmployeeID = s.EmployeeID
        ), 0), 2),
        VacationPay = ROUND(ISNULL(( 
            SELECT SUM(vp.Total) 
            FROM VacationPay vp 
            WHERE vp.EmployeeID = s.EmployeeID
        ), 0), 2),
        SickPay = ROUND(ISNULL(( 
            SELECT SUM(sp.Total) 
            FROM SickPay sp 
            WHERE sp.EmployeeID = s.EmployeeID
        ), 0), 2)
    FROM Salary s;
    UPDATE s
    SET 
        PersonalIncomeTax = ROUND((s.HourlyCharges + s.PieceworkCharges + s.VacationPay + s.SickPay) * 0.13, 2),
        Contributions = ROUND((s.HourlyCharges + s.PieceworkCharges + s.VacationPay + s.SickPay) * 0.3, 2)
    FROM Salary s;
END;

CREATE TRIGGER trg_CalculateVacationPay
ON VacationPay
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE vp
    SET AverageDailyEarnings = ROUND(ISNULL((SELECT SUM(s.HourlyCharges + s.PieceworkCharges) / 30.4 FROM Salary s WHERE s.EmployeeID = vp.EmployeeID), 0), 2)
    FROM VacationPay vp;
    UPDATE s
    SET VacationPay = ROUND(ISNULL((SELECT SUM(vp.Total) FROM VacationPay vp WHERE vp.EmployeeID = s.EmployeeID), 0), 2)
    FROM Salary s;
END;

CREATE TRIGGER trg_CalculateSickPay
ON SickPay
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE sp
    SET Experience = DATEDIFF(YEAR, e.DateOfEmployment, GETDATE()),
        AverageDailyEarnings = ROUND(ISNULL((SELECT SUM(s.HourlyCharges + s.PieceworkCharges) / 30.4 FROM Salary s WHERE s.EmployeeID = sp.EmployeeID), 0), 2)
    FROM SickPay sp
    JOIN Employees e ON sp.EmployeeID = e.EmployeeID;
    UPDATE s
    SET SickPay = ROUND(ISNULL((SELECT SUM(sp.Total) FROM SickPay sp WHERE sp.EmployeeID = s.EmployeeID), 0), 2)
    FROM Salary s;
END;

INSERT INTO Genders (Gender) VALUES
('Мужской'),
('Женский');

INSERT INTO Posts (Post) VALUES
('Менеджер'),
('Инженер'),
('Оператор'),
('Бухгалтер'),
('Директор');

INSERT INTO TypesOfRemuneration (TypeOfRemuneration) VALUES
('Почасовая оплата'),
('Сдельная оплата');

INSERT INTO Months (MonthName, WorkingHours) VALUES
('Январь', 160),
('Февраль', 160),
('Март', 160),
('Апрель', 160),
('Май', 160),
('Июнь', 160);

INSERT INTO Projects (ProjectName, Hourly, PieceWork) VALUES
('Проект 1', 500, 1000),
('Проект 2', 600, 1200),
('Проект 3', 550, 1100);

INSERT INTO Employees (FullName, BirthDate, BirthPlace, PassportSeries, PassportNumber, Phone, Email, INN, PostID, GenderID) VALUES
('Иван Иванов', '1985-04-15', 'Москва', '1234', '123456', '+7 999 111 2233', 'ivanov@mail.ru', '123456789012', 1, 1),
('Анна Смирнова', '1990-08-22', 'Санкт-Петербург', '5678', '654321', '+7 999 222 3344', 'smirnova@mail.ru', '234567890123', 2, 2),
('Петр Петров', '1987-02-10', 'Воронеж', '9101', '987654', '+7 999 333 4455', 'petrov@mail.ru', '345678901234', 3, 1);

INSERT INTO SalaryAccruals (Year, MonthID, ProjectID) VALUES
(2025, 1, 1),
(2025, 2, 2),
(2025, 3, 3);

INSERT INTO Salary (SalaryAccrualID, EmployeeID) VALUES
(1, 1),
(2, 2),
(3, 3);

INSERT INTO AccountingsOfWorkingHours (EmployeeID, ProjectID, TypeOfRemunerationID, HoursOfWork) VALUES
(1, 1, 1, 8),
(2, 2, 2, 8),
(3, 3, 2, 8);

INSERT INTO VacationPay (EmployeeID, VacationStartDate, VacationEndDate) VALUES
(1, '2025-06-01', '2025-11-01'),
(2, '2025-07-01', '2025-12-01');

INSERT INTO SickPay (EmployeeID, SickStartDate, SickEndDate) VALUES
(1, '2025-03-01', '2025-08-01'),
(3, '2025-03-08', '2025-08-08');

INSERT INTO Registration (UserLogin, UserPassword, IsAdmin) VALUES
('admin', 'admin', 1),
('user', 'user', 0);

SELECT * FROM Genders;
SELECT * FROM Posts;
SELECT * FROM TypesOfRemuneration;
SELECT * FROM Months;
SELECT * FROM Projects;
SELECT * FROM Employees;
SELECT * FROM SalaryAccruals;
SELECT * FROM Salary;
SELECT * FROM AccountingsOfWorkingHours;
SELECT * FROM VacationPay;
SELECT * FROM SickPay;
SELECT * FROM Registration;

-- 1. Отчёт по начислению зарплат сотрудников за месяц
SELECT 
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
ORDER BY sa.Year DESC, m.MonthID DESC, e.FullName;

-- 2. Отчёт по отработанным часам сотрудников за период
SELECT 
    e.FullName,
    p.ProjectName,
    t.TypeOfRemuneration,
    SUM(a.HoursOfWork) AS TotalHoursWorked
FROM AccountingsOfWorkingHours a
JOIN Employees e ON a.EmployeeID = e.EmployeeID
JOIN Projects p ON a.ProjectID = p.ProjectID
JOIN TypesOfRemuneration t ON a.TypeOfRemunerationID = t.TypeOfRemunerationID
GROUP BY e.FullName, p.ProjectName, t.TypeOfRemuneration
ORDER BY e.FullName, p.ProjectName;

-- 3. Отчёт по отпускным и больничным выплатам
SELECT 
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
ORDER BY e.FullName;

DROP DATABASE WorkTrack;

use w;