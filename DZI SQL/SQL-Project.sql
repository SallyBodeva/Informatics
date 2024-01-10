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
	Age INT,
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