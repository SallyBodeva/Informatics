CREATE DATABASE Travel;

USE Travel;

CREATE TABLE Countries
(
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(30) NOT NULL
);

CREATE TABLE Destinations
(
	ID INT PRIMARY KEY IDENTITY,
	Town NVARCHAR(30) NOT NULL,
	Distance INT NOT NULL,
	Duration INT NOT NULL,
	Price DECIMAL(10,2) NOT NULL,
	CountryId INT NOT NULL,
		CONSTRAINT fk_Destinations_Countries
		FOREIGN KEY (CountryId)
		REFERENCES Countries(ID)
);

INSERT INTO Countries (Name)
VALUES 
('France'),
('Germany'),
('Italy'),
('Spain'),
('Austria');

INSERT INTO Destinations(Town,Distance,Duration,Price,CountryId)
VALUES
( 'Paris', 2169, 4, 1800.00, 1),
( 'Berlin', 4006, 6, 2100.00, 2),
( 'Rome', 1666, 3, 1500.00, 3),
( 'Madrid', 2966, 7, 1800.00, 4),
( 'Milan', 1408, 4, 1900.00, 3),
( 'Venice', 1152, 3, 1200.00, 3),
( 'Barcelona',2375, 7, 2800.00, 4);