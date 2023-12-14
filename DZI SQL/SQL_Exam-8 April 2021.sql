CREATE DATABASE Service;

USE Service;

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) UNIQUE NOT NULL,
	Password VARCHAR(50) NOT NULL,
	Name VARCHAR(50),
	BirthDate DATETIME2,
	Age INT,
	CHECK(Age>= 14 AND Age<=110),
	Email VARCHAR(50) NOT NULL
);

CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL
);

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(25),
	LastName VARCHAR(25),
	Birthdate DATETIME2,
	Age INT,
	CHECK(Age>=18 AND Age<=110),
	DepartmentId INT NOT NULL,
		CONSTRAINT fk_Employees_Departments
			FOREIGN KEY (DepartmentId)
			REFERENCES Departments(Id)
);

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	DepartmentId INT NOT NULL,
		CONSTRAINT fk_Categories_Departments
			FOREIGN KEY (DepartmentId)
			REFERENCES Departments(Id)
);

CREATE TABLE Status
(
	Id INT PRIMARY KEY IDENTITY,
	Label VARCHAR(20) NOT NULL,	
);

CREATE TABLE Reports
(
	Id INT PRIMARY KEY IDENTITY,
	CategoryId INT NOT NULL,
	StatusId INT NOT NULL,
	OpenDate DATETIME2 NOT NULL,
	CloseDate DATETIME2,
	Description VARCHAR(200) NOT NULL,
	UserId INT NOT NULL,
	EmployeeId INT,
		CONSTRAINT fk_Reports_Categories
			FOREIGN KEY (CategoryId)
			REFERENCES Categories(Id),
		CONSTRAINT fk_Reports_Status
			FOREIGN KEY (StatusId)
			REFERENCES Status(Id),
		CONSTRAINT fk_Reports_Users
			FOREIGN KEY (UserId)
			REFERENCES Users(Id),
		CONSTRAINT fk_Reports_Employees
			FOREIGN KEY (EmployeeId)
			REFERENCES Employees(Id),
);

-- 5
SELECT r.Description,FORMAT(r.OpenDate,'dd-MM-yyyy') AS 'OpenDate' FROM Reports AS r
WHERE EmployeeId IS NULL
ORDER BY Description,'OpenDate';

--6
SELECT r.Description,c.Name FROM Reports AS r
JOIN Categories AS c ON c.Id= r.CategoryId
ORDER BY r.Description,c.Name;

-- 7
SELECT  TOP(5) c.Name,COUNT(*)  AS 'ReportsNumber' FROM Categories AS c
JOIN Reports AS r ON r.CategoryId=c.Id
GROUP  BY c.Name
ORDER BY  ReportsNumber DESC, c.Name

--8
SELECT u.Username,c.Name FROM Users AS u
JOIN Reports AS r ON u.Id=r.UserId
JOIN Categories AS c ON c.Id= r.CategoryId
WHERE DAY(u.BirthDate)= DAY(r.OpenDate) AND MONTH(u.BirthDate) = MONTH(r.OpenDate)
ORDER BY u.Username,c.Name;

--9
SELECT COUNT(DISTINCT u.Id) AS 'UsersCount' FROM Employees AS e
JOIN Reports AS r ON r.EmployeeId= e.Id
JOIN Users AS u ON r.UserId=e.Id
GROUP BY e.FirstName,e.LastName