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

--Insert

INSERT INTO Tourists(Name,PhoneNumber,Email,CountryId)
VALUES 
('John Rivers','653-551-1555','john.rivers@example.com',6),
('Adeline Aglaé','122-654-8726','adeline.aglae@example.com',2),
('Sergio Ramirez','233-465-2876','s.ramirez@example.com',3),
('Johan Müller','322-876-9826','j.muller@example.com',7),
('Eden Smith','551-874-2234','eden.smith@example.com',6)


INSERT INTO Bookings(ArrivalDate,DepartureDate,AdultsCount,ChildrenCount,TouristId,HotelId,RoomId)
VALUES
('2024-03-01','2024-03-11',1,0,21,3,5),
('2023-12-28','2024-01-06',	2,1,22,13,3),
('2023-11-15','2023-11-20',1,2,23,19,7)

-- Update

Update Bookings
SET DepartureDate= DATEADD(DAY,1,DepartureDate)
WHERE MONTH(DepartureDate)=12 OR YEAR(DepartureDate)=2023;

UPDATE Tourists
SET Email = null
WHERE Name LIKE '%MA%';

-- Delete

DELETE FROM Tourists
WHERE Name LIKE '% Smith';

-- Querying

SELECT FORMAT(ArrivalDate,'yyyy-MM-dd') ArrivalDate,AdultsCount,ChildrenCount FROM Bookings AS b
JOIN Rooms AS r ON b.RoomId=r.Id
ORDER BY r.Price DESC, ArrivalDate;

SELECT t.Id,t.Name,t.PhoneNumber FROM Tourists AS t
WHERE t.Id NOT IN (SELECT TouristId FROM Bookings)
ORDER BY Name;
