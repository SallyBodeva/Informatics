CREATE DATABASE CigarShop;
USE CigarShop;
--DDL
CREATE TABLE Sizes
(
	Id INT PRIMARY KEY IDENTITY,
	Length INT NOT NULL CHECK (Length>10 AND Length<25),
	RingRange DECIMAL NOT NULL CHECK (RingRange>1.5 AND RingRange<7.5)
);

CREATE TABLE Tastes
(
	Id INT PRIMARY KEY IDENTITY,
	TasteType VARCHAR(20)NOT NULL,
	TasteStrength VARCHAR(15)NOT NULL,
	ImageURL NVARCHAR(100)NOT NULL
);

CREATE TABLE Brands
(
	Id INT PRIMARY KEY IDENTITY,
	BrandName VARCHAR(30) UNIQUE NOT NULL,
	BrandDescription VARCHAR(max)
);

CREATE TABLE Cigars
(
	Id INT PRIMARY KEY IDENTITY,
	CigarName VARCHAR(80) NOT NULL,
	BrandId INT NOT NULL,
	TastId INT NOT NULL,
	SizeId INT NOT NULL,
	PriceForSingleCigar DECIMAL NOT NULL,
	ImageURL VARCHAR(100) NOT NULL,
		CONSTRAINT fk_Cigars_Brands
			FOREIGN KEY (BrandId)
			REFERENCES Brands(id),
		CONSTRAINT fk_Cigars_Tastes
			FOREIGN KEY (TastId)
			REFERENCES Tastes(id),
		CONSTRAINT fk_Cigars_Sizes
			FOREIGN KEY (SizeId)
			REFERENCES Sizes(id),
);

CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	Town VARCHAR(30) NOT NULL,
	Country NVARCHAR(30) NOT NULL,
	Streat NVARCHAR(100) NOT NULL,
	ZIP VARCHAR(20) NOT NULL
);

CREATE TABLE Clients
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	AddressId INT NOT NULl,
		CONSTRAINT fk_Clients_Addresses
			FOREIGN KEY (AddressId)
			REFERENCES Addresses(id),
);

CREATE TABLE ClientsCigars
(
	ClientId INT NOT NULL,
	CigarId INT NOT NULL,
		CONSTRAINT pk_Cigars
			PRIMARY KEY (ClientId,CigarId),
		CONSTRAINT fk_ClientsCigars_Clients
			FOREIGN KEY (ClientId)
			REFERENCES Clients(id),
		CONSTRAINT fk_ClientsCigars_Cigars
			FOREIGN KEY (CigarId)
			REFERENCES Cigars(id)
);
--INSERT
INSERT INTO Cigars(Id,CigarName,BrandId,TastId,SizeId,PriceForSingleCigar,ImageURL)
VALUES
('COHIBA ROBUSTO',9,1,5,15.50,'cohiba-robusto-stick_18.jpg'),
('COHIBA SIGLO I',9,1,10,410.00,'cohiba-siglo-i-stick_12.jpg'),
('HOYO DE MONTERREY LE HOYO DU MAIRE',14,5,11,7.50,'hoyo-du-maire-stick_17.jpg'),
('HOYO DE MONTERREY LE HOYO DE SAN JUAN',14,4,15,32.00,'hoyo-de-san-juan-stick_20.jpg'),
('TRINIDAD COLONIALES',2,3,8,85.21,'trinidad-coloniales-stick_30.jpg')

INSERT INTO Addresses(Town,Country,Streat,ZIP)
VALUES 
('Sofia','Bulgaria', '18 Bul. Vasil levski'	,'1000'),
('Athens','Greece', '4342 McDonald Avenue'	,'10435'),
('Zagreb','Croatia', '4333 Lauren Drive'	,'10000')

--UPDATES
UPDATE Cigars
SET PriceForSingleCigar= PriceForSingleCigar*1.2
WHERE TastId IN (SELECT Id FROM Tastes WHERE TasteType='Spicy');

UPDATE Brands
SET BrandDescription='New description'
WHERE BrandDescription IS NULL;

--Queries
SELECT CigarName,PriceForSingleCigar,ImageURL FROM Cigars
ORDER BY PriceForSingleCigar, CigarName DESC;

SELECT c.ID,CigarName,PriceForSingleCigar,TasteType,TasteStrength FROM Cigars AS c
JOIN Tastes AS t on t.Id=c.TastId
WHERE TasteType='Earthy' OR TasteType='Woody'
ORDER BY PriceForSingleCigar DESC;

SELECT Id, CONCAT_WS(' ',FirstName,LastName) AS ClientName,Email FROM Clients
WHERE Id NOT IN (SELECT ClientId FROM ClientsCigars)
ORDER BY ClientName;

SELECT TOP(5) c.CigarName,c.PriceForSingleCigar,c.ImageURL FROM Cigars AS c
JOIN Sizes AS s On s.Id=c.SizeId
WHERE s.Length>=12 AND (c.CigarName LIKE '%ci%' OR  c.PriceForSingleCigar>50) AND s.RingRange >2.55
ORDER BY c.CigarName,c.PriceForSingleCigar DESC;