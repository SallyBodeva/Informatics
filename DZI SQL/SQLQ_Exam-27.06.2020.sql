CREATE DATABASE WashingMachineService;
USE WashingMachineService;

CREATE TABLE Clients
(
	ClientId INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Phone VARCHAR(12),
	CHECK (Phone=12)
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
	Status VARCHAR(11) DEFAULT 'Pending'
	Check (Status = 'In Progress' OR Status = 'Finished' OR Status = 'Pending'),
	ClientId INT NOT NULL,
	MechanicId INT NOT NULL,
	IssueDate DATETIME2 NOT NULL,
	FinishDate DATETIME2,
		CONSTRAINT fk_Jobs_Mechanics
			FOREIGN KEY(MechanicId)
			REFERENCES Mechanics(MechanicId),
		CONSTRAINT fk_Jobs_Clients
			FOREIGN KEY(ClientId)
			REFERENCES Clients(ClientId),
		CONSTRAINT fk_Jobs_Models
			FOREIGN KEY(ModelId)
			REFERENCES Models(ModelId)
);

CREATE TABLE Models
(
	ModelId INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) UNIQUE
);

CREATE TABLE Orders
(
	OrderId INT PRIMARY KEY IDENTITY,
	JobId INT NOT NULL,
	IssueDate DATETIME2,
	Delivered BIT DEFAULT 0,
		CONSTRAINT fk_Orders_Jobs
			FOREIGN KEY (JobId)
			REFERENCES Jobs(JobId)
);

CREATE TABLE Parts
(
	PartId INT PRIMARY KEy IDENTITY,
	SerialNumber VARCHAR(50) UNIQUE,
	Description VARCHAR(255),
	Price DECIMAL NOT NULL,
	CHECK (Price >0 AND Price <10000),
	VendorId INT NOT NULL,
	StockQty INT NOT NULL DEFAULT 0,
	CHECK (StockQty>0),
		CONSTRAINT fk_Parts_Vendors
			FOREIGN KEY(VendorId)
			REFERENCES Vendors(VendorId)
);

CREATE TABLE Vendors
(
	VendorId INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) UNIQUE
);

CREATE TABLE PartsNeeded
(
	JobId INT NOT NULL,
	PartId INT NOT NULL,
	Quantity INT DEFAULT 1,
	CHECK (Quantity>0),
		CONSTRAINT pk_PartsNeeded
			PRIMARY KEY (JobId,PartId),
		CONSTRAINT fk_PartsNeeded_Jobs
			FOREIGN KEY (JobId)
			REFERENCES Jobs(JobId),
		CONSTRAINT fk_PartsNeeded_Parts
			FOREIGN KEY (PartId)
			REFERENCES Parts(PartId)
);

-- Querying 

-- Problem 5 Mechanic Assignments
SELECT  CONCAT_WS(' ',m.FirstName,m.LastName) AS 'Mechanic', j.Status,j.IssueDate FROM Mechanics AS m
JOIN Jobs AS j ON j.MechanicId=m.MechanicId
ORDER BY m.MechanicId, j.IssueDate,j.JobId;

-- Problem 6 Current Clients

SELECT CONCAT_WS(' ',c.FirstName,c.LastName) AS 'Client',(DATEDIFF(DAY,j.IssueDate,'2017/04/24')) AS 'Days going',j.Status FROM Clients AS c
JOIN Jobs AS j ON j.ClientId=c.ClientId
WHERE j.Status='In Progress'
ORDER BY [Days going] DESC, c.ClientId ASC;
