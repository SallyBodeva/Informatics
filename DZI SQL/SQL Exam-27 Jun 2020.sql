CREATE DATABASE WasingMechineService;

USE WasingMechineService;

CREATE TABLE Clients
(
	ClientId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Phone VARCHAR(12),
	CHECK (LEN(Phone)=12)
);

CREATE TABLE Mechanics
(
	MechanicId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Address VARCHAR(255)
);

CREATE TABLE Jobs
(
	JobId INT PRIMARY KEY IDENTITY,
	ModelId INT NOT NULL,
	Status VARCHAR(11) DEFAULT 'Pending',
	CHECK (Status IN ('Pending', 'In Progress','Finished')),
	ClientId INT NOT NULL,
	MechanicId INT NOT NULL,
	IssueDate DATETIME2 NOT NULL,
	FinishDate INT,
		CONSTRAINT fk_Jobs_Models
			FOREIGN KEY (ModelId)
			REFERENCES Models(ModelId),
		CONSTRAINT fk_Jobs_Clients
			FOREIGN KEY (ClientId)
			REFERENCES Clients(ClientId)
);

CREATE TABLE Models
(
	ModelId INT PRIMARY KEY IDENTITY,
	[Name]  VARCHAR(50) UNIQUE NOT NULL
);

CREATE TABLE Orders
(
	OrderId INT PRIMARY KEY IDENTITY,
	JobId INT NOT NULL,
	IssueDate DATETIME2,
	Delivered BIT DEFAULT 0,
		CONSTRAINT fk_Orders_Jobs
			FOREIGN KEY(JobId)
			REFERENCES Jobs(JobId)
);