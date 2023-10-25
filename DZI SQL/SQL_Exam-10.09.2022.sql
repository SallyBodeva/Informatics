CREATE DATABASE TouristSite;
USE TouristSite;

CREATE TABLE Categories
(
	Id INT PRIMARY KEY IDENTITY,
	[name] VARCHAR(50) NOT NULL
);

CREATE TABLE Locations
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Municipality VARCHAR(50),
	Province VARCHAR(50)
);
CREATE TABLE Sites
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	LocationId INT NOT NULL,
	CategoryId INT NOT NULL,
	Establishment VARCHAR(15),
		CONSTRAINT fk_Sites_Locations
			FOREIGN KEY(LocationId)
			REFERENCES Locations(Id),
		CONSTRAINT fk_Sites_Categories
			FOREIGN KEY(CategoryId)
			REFERENCES Categories(Id)
);

CREATE TABLE Tourists
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	Age INT NOT NULL,
	 CHECK (Age>=0),
	 CHECK (Age<=120),
	PhoneNumber VARCHAR(20) NOT NULL,
	Nationality VARCHAR(20) NOT NULL,
	Reward VARCHAR(20)
);

CREATE TABLE SitesTourists
(
	TouristId INT NOT NULL,
	SiteId INT NOT NULL,
	CONSTRAINT pk_SitesTourists
		PRIMARY KEY (TouristId,SiteId),
	CONSTRAINT fk_SitesTourists_Tourists
		FOREIGN KEY (TouristId)
		REFERENCES Tourists(Id),
	CONSTRAINT fk_SitesTourists_Sites
		FOREIGN KEY (SiteId)
		REFERENCES Sites(Id)
);
CREATE TABLE BonusPrizes
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
);

CREATE TABLE TouristsBonusPrizes
(
	TouristId INT NOT NULL,
	BonusPrizeId INT NOT NULL,
	CONSTRAINT pk_TouristsBonusPrizes
		PRIMARY KEY (TouristId,BonusPrizeId),
	CONSTRAINT fk_SitesTourists_Tourists2
		FOREIGN KEY (TouristId)
		REFERENCES Tourists(Id),
	CONSTRAINT fk_SitesTourists_BonusPrizes
		FOREIGN KEY (BonusPrizeId)
		REFERENCES BonusPrizes(Id),
);

INSERT INTO Tourists (Name,Age,PhoneNumber,Nationality,Reward)
Values
('Borislava Kazakova',52,'+359896354244','Bulgaria',NULL),
('Peter Bosh',48,'+447911844141','UK',NULL),
('Martin Smith',29,'+353863818592','Ireland','Bronze badge'),
('Svilen Dobrev',49,'+359986584786','Bulgaria','Silver badge'),
('Kremena Popova',38,'+359893298604','Bulgaria',NULL);

SELECT * FROM Tourists
ORDER BY Nationality, age DESC, Name