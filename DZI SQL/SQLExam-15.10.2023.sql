CREATE DATABASE TouristAgency;
USE TouristAgency;

CREATE TABLE Countries
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Destinations
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	CountryId INT NOT NULL,
		CONSTRAINT fk__Destinations_Countries
			FOREIGN KEY (CountryId)
			REFERENCES Countries(Id)
);

CREATE TABLE Rooms
(
	Id INT PRIMARY KEY IDENTITY,
	Type VARCHAR(40) NOT NULL,
	Price DECIMAL(18,2) NOT NULL,
	BedCount INT NOT NULL,
		CHECK ( BedCount >=0 AND  BedCount<=10)
);

CREATE TABLE Hotels
(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL,
	DestinationId INT NOT NULL,
		CONSTRAINT fk_Hotels_Destinations
			FOREIGN KEY (DestinationId)
			REFERENCES Destinations(Id)
);

CREATE TABLE Tourists
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(80) NOT NULL,
	PhoneNumber VARCHAR(20) NOT NULL,
	Email VARCHAR(80) NOT NULL,
	CountryId INT NOT NULL,
		CONSTRAINT fk_Tourists_Countries
			FOREIGN KEY (CountryId)
			REFERENCES Countries(Id)
);

CREATE TABLE Bookings
(
	Id INT PRIMARY KEY IDENTITY,
	ArrivalDate DATETIME2 NOT NULL,
	DepartureDate DATETIME2 NOT NULL,
	AdultsCount INT NOT NULL,
		CHECK (AdultsCount>=1 AND AdultsCount<=10),
	ChildrenCount INT NOT NULL,
		CHECK (AdultsCount>=0 AND AdultsCount<=9),
	TouristId INT NOT NULL,
	HotelId INT NOT NULL,
	RoomId INT NOT NULL,
		CONSTRAINT fk_Bookings_Tourists
			FOREIGN KEY (TouristId)
			REFERENCES Tourists(Id),
		CONSTRAINT fk_Bookings_Hotels
			FOREIGN KEY (HotelId)
			REFERENCES Hotels(Id),
		CONSTRAINT fk_Bookings_Rooms
			FOREIGN KEY (RoomId)
			REFERENCES Rooms(Id),
);

CREATE TABLE HotelsRooms
(
	HotelId INT NOT NULL,
	RoomId INT NOT NULL,
		CONSTRAINT pk_HotelsRooms
			PRIMARY KEY (HotelId,RoomId),
		CONSTRAINT fk_HotelsRooms_Hotels
			FOREIGN KEY (HotelId)
			REFERENCES Hotels(Id),
		CONSTRAINT fk_HotelsRooms_Rooms
			FOREIGN KEY (RoomId)
			REFERENCES Rooms(Id)

);