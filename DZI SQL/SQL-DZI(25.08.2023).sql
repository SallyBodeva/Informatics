CREATE DATABASE Music1;

USE Music1;

CREATE TABLE Singers
(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(max) NOT NULL,
	Songs INT NOT NULL,
	Rank INT NOT NULL,
	NetWorth INT NOT NULL
);

INSERT INTO Singers(Name,Songs,Rank,NetWorth)
VALUES 
('Ivan Ivanov',50,1,1000000),
('Maria Ivanova',55,3,900000),
('Georgi Georgiev',20,4,800000),
('Gergana Petrova',55,2,1000000),
('Boris Borisov',20,5,900000)

SELECT TOP(3) Name,Rank FROM Singers
ORDER BY Rank

SELECT SUM(Songs) AS Songs_Count,AVG(NetWorth)/1.95583 AS AVERAGE_NetWorth FROM Singers

UPDATE Singers
SET NetWorth= NetWorth*1.1
WHERE ID in (2,3,4);
