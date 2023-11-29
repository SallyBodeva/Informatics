CREATE DATABASE TripService;

USE TripService;

CREATE TABLE Cities
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL,
    CountryCode VARCHAR(2) NOT NULL,
    CHECK(Len(CountryCode)=2)
);
CREATE TABLE Hotels
(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(50) NOT NULL,
    CityId INT NOT NULL,
    EmployeeCount INT NOT NULL,
    BaseRate DECIMAL(12,2)
    CONSTRAINT fk_cities_Hotels
    FOREIGN KEY (CityId)
    REFERENCES Cities(Id)
)
CREATE TABLE Rooms
(
    Id INT PRIMARY KEY IDENTITY,
    Price DECIMAL(12,2) NOT NULL,
    Type NVARCHAR(20) NOT NULL,
    Beds INT NOT NULL,
    HotelId INT NOT NULL
    CONSTRAINT fk_Hotels_Rooms
    FOREIGN KEY (HotelId)
    REFERENCES Hotels(id)
)
CREATE TABLE Trips
(
    Id INT PRIMARY KEY IDENTITY,
    RoomId INT NOT NULL,
    BookDate DATETIME2 NOT NULL,
    CHECK(BookDate < ArrivalDate),
    ArrivalDate DATETIME2 NOT NULL,
    CHECK(ArrivalDate < ReturnDate),
    ReturnDate DATETIME2 NOT NULL,
    CancelDate DATETIME2
    CONSTRAINT fk_Trips_Rooms
    FOREIGN KEY (RoomId)
    REFERENCES Rooms(Id)
)
CREATE TABLE Accounts
(
    Id INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50) NOT NULL,
    MiddleName NVARCHAR(20),
    LastName NVARCHAR(50) NOT NULL,
    CityId INT NOT NULL,
    BirthDate DATETIME2 NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL
    CONSTRAINT fk_cities_accounts
    FOREIGN KEY (CityId)
    REFERENCES Cities(Id)
)
CREATE TABLE AccountsTrips
(
    AccountId INT NOT NULL,
    TripId INT NOT NULL,
    Luggage INT NOT NULL
    CHECK(Luggage >= 0)
    CONSTRAINT fk_Accounts_AccountsTrips
    FOREIGN KEY (AccountId)
    REFERENCES Accounts(Id),
    CONSTRAINT fk_Trips_AccountsTrips
    FOREIGN KEY (TripId)
    REFERENCES Trips(Id)
)
-- 5. EEE-Mails
SELECT FirstName,LastName,FORMAT(BirthDate, 'MM-dd-yyyy'), c.Name AS 'Hometown' ,Email 
FROM Accounts AS A
JOIN Cities AS c ON c.Id=A.CityId
WHERE Email LIKE 'e%'
ORDER BY c.Name ASC

-- 6. City Statistics
SELECT c.Name, COUNT(*) AS Hotels
FROM Cities AS c
JOIN Hotels AS h on H.CityId=c.Id
GROUP BY(c.Name)
ORDER BY Hotels DESC, c.Name 

-- 7. Longest and Shortest Trips
 SELECT a.Id,CONCAT_WS(' ',a.FirstName,a.LastName)  AS FullName,
 MAX(DATEDIFF(DAY,t.ArrivalDate,t.ReturnDate)) AS LongestTrip,
 MIN(DATEDIFF(DAY,t.ArrivalDate,t.ReturnDate)) AS ShortestTrip
 FROM Accounts AS a
 JOIN AccountsTrips AS at ON at.AccountId=a.Id
 JOIN Trips AS t ON t.Id= at.TripId
 WHERE t.CancelDate IS NUll AND a.MiddleName IS NULL
 GROUP BY a.Id, CONCAT_WS(' ',a.FirstName,a.LastName) 
 ORDER BY LongestTrip DESC, ShortestTrip ASC;

 -- 8. Metropolis
 SELECT TOP(10) c.Id,c.Name,c.CountryCode AS Country, COUNT(*) AS Accounts FROM Accounts AS a
 JOIN Cities AS c ON c.Id=a.CityId
 GROUP BY c.Id,c.Name,c.CountryCode
 ORDER BY Accounts DESC;

 -- 9. Romantic Getaways
  SELECT a.Id,a.Email,cH.Name,COUNT(*) AS Trips
 FROM Accounts AS a
 JOIN AccountsTrips AS at ON at.AccountId=a.Id
 JOIN Trips AS t ON t.Id= at.TripId
 JOIN ROOMS AS r ON t.RoomId=r.Id
 JOIN Hotels AS h ON h.Id=r.HotelId
 JOIN Cities AS cH ON cH.Id=a.CityId
 JOIN Cities AS cTo ON cTo.Id=h.CityId
 WHERE ch.Id=cTo.Id
 GROUP BY a.Email,a.Id,cH.Name
 ORDER BY Trips DESC, a.Id

 -- 10. GDPR Violation
 SELECT t.Id, 
 CONCAT_WS(' ',a.FirstName,a.MiddleName,a.LastName) AS FullName,
 cFrom.Name AS [From],
 cTo.Name AS [To], 
 CASE 
WHEN t.CancelDate IS NOT NULL THEN 'Canceled'
ELSE CONCAT(DATEDIFF(DAY, t.ArrivalDate, t.ReturnDate),' ', 'days')
END AS Duration
 FROM Accounts AS a
 JOIN AccountsTrips AS at ON at.AccountId=a.Id
 JOIN Cities AS cFrom ON cFrom.Id=a.CityId
 JOIN Trips AS t ON t.Id= at.TripId
 JOIN ROOMS AS r ON t.RoomId=r.Id
 JOIN Hotels AS h ON h.Id=r.HotelId
 JOIN Cities AS cTo ON cTo.Id=h.CityId
 ORDER BY FullName, t.Id;

