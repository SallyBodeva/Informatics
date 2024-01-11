CREATE DATABASE EventManagmentSystem;

USE EventManagmentSystem;

CREATE TABLE Town
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(200) NOT NULL
);

CREATE TABLE Address
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(200) NOT NULL,
	TownId INT NOT NULL,
		CONSTRAINT fk_Address_Town
			FOREIGN KEY (TownId)
			REFERENCES Town(Id)
);

CREATE TABLE Attendee
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NUll,
	LastName NVARCHAR(50) NOT NULL,
	Age INT,
	Email VARCHAR(100) NOT NULL
);

CREATE TABLE Sponsor
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(100) NOT NULL,
	PhoneNum VARCHAR(10) NOT NULL,
	Email VARCHAR(100) NOT NULL
);

CREATE TABLE Employee
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NUll,
	LastName NVARCHAR(50) NOT NULL,
	Age INT NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Position VARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(10) NOT NULL
);

CREATE TABLE TicketType
(
	Id INT PRIMARY KEY IDENTITY,
	TypeName VARCHAR(100) NOT NULL
);

CREATE TABLE Ticket
(
	Id INT PRIMARY KEY IDENTITY,
	Price DECIMAL(12,2) NOT NULL,
	AttendeeId INT NOT NULL,
	TicketTypeId INT NOT NULL,
		CONSTRAINT fk_Ticket_Attendee
			FOREIGN KEY (AttendeeId)
			REFERENCES Attendee(Id),
		CONSTRAINT fk_Ticket_TicketType
			FOREIGN KEY (TicketTypeId)
			REFERENCES TicketType(Id)
);

CREATE TABLE Event
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	AddressId INT NOT NULL,
	SponsorId INT NOT NULL,
	DateOfTakingPlace DATE NOT NULL,
	Budget DECIMAL(12,2) NOT NULL,
		CONSTRAINT fk_Event_Address
			FOREIGN KEY (AddressId)
			REFERENCES Address(Id),
		CONSTRAINT fk_Event_Sponsor
			FOREIGN KEY (SponsorId)
			REFERENCES Sponsor(Id)
);

CREATE TABLE AttendeeEvent
(
	AtendeeId INT NOT NULL,
	EventId INT NOT NULL,
		CONSTRAINT pk_AttendeeEvent
			PRIMARY KEY (AtendeeId,EventId),
		CONSTRAINT fk_AttendeeEvent_Attendee
			FOREIGN KEY (AtendeeId)
			REFERENCES Attendee(Id),
		CONSTRAINT fk_AttendeeEvent_Event
			FOREIGN KEY (EventId)
			REFERENCES Event(Id)
);

CREATE TABLE EmployeeEvent
(
	EmployeeId INT NOT NULL,
	EventId INT NOT NULL,
		CONSTRAINT pk_EmployeeEvent
			PRIMARY KEY (EmployeeId,EventId),
		CONSTRAINT fk_EmployeeEvent_Employee
			FOREIGN KEY (EmployeeId)
			REFERENCES Employee(Id),
		CONSTRAINT fk_EmployeeEvent_Event
			FOREIGN KEY (EventId)
			REFERENCES Event(Id)
);

INSERT INTO Town(Name)
VALUES ('London'),
       ('Paris'),
       ('Sofia'),
       ('Plovdiv'),
       ('Burgas');

INSERT INTO Address(Name,TownId)
VALUES ('Potter str ¹7',1),
       ('Vitosha bul',3),
       ('Petko Voivoda', 4),
       ('Kraibrezna',5);

INSERT INTO Attendee(FirstName,LastName,Age,Email)
VALUES ('Mitko','Kovachev',45,'mitkp@abv.bg'),
       ('Elena','Petrova',2,'eli@abv.bg'),
       ('John','Potter',35,'John@abv.bg'),
       ('Kaya','McDaisy',19,'kayap@abv.bg');

INSERT INTO Sponsor(Name,PhoneNum,Email)
VALUES ('LG','02938823','lg@gmai.com'),
       ('Pepsi','034323','pepsi@gmai.com'),
       ('Billa','03443423','billa@gmai.com'),
       ('XIXO','029343','xixo@gmai.com');

INSERT INTO Employee(FirstName,LastName,Age,Email,Position,PhoneNumber)
VALUES ('John', 'Harrison',29,'john@gmail.com','Manager','0929389330'),
       ('Milla', 'Roberts',35,'milla@gmail.com','PR agent','023289330'),
       ('Anna', 'Smith',40,'anna@gmail.com','Assisnant','02323330'),
       ('Will', 'Nowels',19,'eva@gmail.com','Security','0829389330');

INSERT INTO TicketType(TypeName)
VALUES ('VIP'),
       ('Standart'),
       ('Platinum'),
       ('Kid <7');

INSERT INTO Ticket(Price,AttendeeId,TicketTypeId)
VALUES (18.99,1,2),
       (99.99,2,1),
       (150,3,3),
       (18.99,3,4);

INSERT INTO Event(Name,AddressId,SponsorId,DateOfTakingPlace,Budget)
VALUES ('The Voice Tour', 1,2,'12-22-2024',10.000),
       ('Game Contest', 2,1,'09-10-2024',1.000),
       ('Basketball tournament', 3,4,'01-01-2025',60.000),
       ('New Year Eve Concert', 1,1,'12-31-2023',5.000);

INSERT INTO AttendeeEvent(AtendeeId,EventId)
VALUES (1,1),
       (1,2),
       (2,3),
       (3,4);

INSERT INTO EmployeeEvent(EmployeeId,EventId)
VALUES (1,1),
       (1,2),
       (2,3),
       (3,4);


-- Quiries

SELECT * FROM Attendee AS a
JOIN AttendeeEvent AS ae ON ae.AtendeeId= a.Id
JOIN Event AS e ON e.Id= ae.EventId
WHERE a.Age>35
ORDER BY a.Id;

SELECT CONCAT_WS(' ',FirstName,LastName) AS 'Employee',ev.Name AS 'Event',s.Name AS 'Sponsor' FROM Employee AS e
JOIN EmployeeEvent AS  ee ON ee.EmployeeId= e.Id
JOIN Event AS ev ON ev.Id= ee.EventId
JOIN Sponsor AS s ON s.Id = ev.SponsorId
ORDER BY Sponsor;

SELECT CONCAT_WS(' ',FirstName,LastName) AS 'Attendee',t.Price,tt.TypeName FROM Attendee AS a
JOIN Ticket AS t ON t.AttendeeId=a.Id
JOIN TicketType AS tt ON tt.Id= t.Id;


SELECT * FROM Event
WHERE LEN(Name)< 15 AND Budget<15000
ORDER BY id;

SELECT * FROM Employee
 WHERE Position IN ('PR agent','Security')
 ORDER BY Age;

SELECT * FROM Ticket AS t
JOIN TicketType AS tt ON tt.Id= t.TicketTypeId;