CREATE DATABASE Online_auction;

USE online_auction;

CREATE TABLE Cities(
	Id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(40) NOT NULL,
	country_name NVARCHAR(50) NOT NULL
);

CREATE TABLE Persons
(
	Id INT PRIMARY KEY IDENTITY,
	first_name NVARCHAR(50) NOT NULL,
	middle_name NVARCHAR(20),
	last_name NVARCHAR(50) NOT NULL,
	birthdate DATETIME2 NOT NULL,
	city_id INT NOT NULL,
		CONSTRAINT fk_persons_citites
			FOREIGN KEY (city_id)
			REFERENCES cities(id)
);

CREATE TABLE Product_types
(
	Id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(30) UNIQUE NOT NULL,
);

CREATE TABLE Products
(
	Id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(50) NOT NULL,
	description NVARCHAR(1024),
	start_bid_price DECIMAL(15,2) NOT NULL,
	sold_on DATETIME2,
	owner_id INT NOT NULL,
	sold_city_id INT NOT NULL,
	product_type_id INT NOT NULL,
		CONSTRAINT fk_products_persons
			FOREIGN KEY (owner_id)
			REFERENCES persons(id),
		CONSTRAINT fk_products_cities
			FOREIGN KEY (sold_city_id)
			REFERENCES cities(id),
		CONSTRAINT fk_products_product_type
			FOREIGN KEY (product_type_id)
			REFERENCES Product_types(id)
);

CREATE TABLE Bids
(
	product_id INT NOT NULL,
	person_id INT NOT NULL,
	amount DECIMAL(15,2) NOT NULL,
	date DATETIME2 NOT NULL,
	CONSTRAINT pk_Bids
			PRIMARY KEY (product_id,person_id),
		CONSTRAINT fk_Bids_Products
			FOREIGN KEY (product_id)
			REFERENCES products(id),
		CONSTRAINT fk_Bids_persons
			FOREIGN KEY (person_id)
			REFERENCES persons(id)
);

--Queries

SELECT id,CONCAT_WS(' ',first_name,last_name) AS 'Full_name', YEAR(birthdate) AS 'Birth_year' FROM Persons
WHERE city_id=42 AND YEAR(birthdate)>1970
ORDER BY YEAR(birthdate) ASC, CONCAT_WS(' ',first_name,last_name);

SELECT p.Id,p.name AS 'product_name', start_bid_price,pt.name FROM Products AS p
JOIN Product_types AS pt ON p.product_type_id= pt.Id
WHERE sold_on IS NULL
ORDER BY start_bid_price ASC;

SELECT pro.Id,pro.name,p.first_name,p.last_name,c.name,c.country_name FROM Persons AS p
JOIN Products AS pro ON p.Id= pro.owner_id
JOIN Cities AS c ON c.Id= pro.sold_city_id
WHERE p.first_name='Britni ' AND c.country_name='Germany'
ORDER BY pro.Id;