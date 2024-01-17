CREATE DATABASE Scooters;

USE Scooters;

CREATE TABLE cities
(
	city_id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(30) NOT NULL
);

CREATE TABLE users
(
	user_id INT PRIMARY KEY IDENTITY,
	username NVARCHAR(90) UNIQUE NOT NULL,
	password NVARCHAR(255) NOT NULL,
	first_name NVARCHAR(255) NOT  NULL,
	last_name NVARCHAR(255),
	balance DECIMAL(15,2) NOT NULL,
	city_id INT NOT NULL,
	register_date DATETIME2 NOT NULL,
		CONSTRAINT fk_users_cities
			FOREIGN KEY(city_id)
			REFERENCES cities(city_id)
);
CREATE TABLE rents
(
	rent_id INT PRIMARY KEY IDENTITY,
	user_id INT NOT NULL,
	scooter_id INT NOT NULL,
	start_date DATETIME2 NOT NULL,
    end_date DATETIME2,
	is_completed BIT DEFAULT 0,
		CONSTRAINT fk_rents_users
			FOREIGN KEY(user_id)
			REFERENCES users(user_id),
		CONSTRAINT fk_rents_scooters
			FOREIGN KEY(scooter_id)
			REFERENCES scooters(scooter_id)
);

CREATE TABLE scooters
(
	scooter_id INT PRIMARY KEY IDENTITY,
	model NVARCHAR(255) NOT NULL,
	gps_position NVARCHAR(255) NOT NULL,
	is_taken BIT DEFAULT 0
);

--Quering

-- Градове

SELECT TOP(5) name FROM cities
ORDER BY name;

-- Потребители с нулев баланс
SELECT username,register_date FROM users
WHERE balance=0
ORDER BY register_date DESC, username ASC

-- Най-голям баланс на софийски потребители
SELECT TOP(1) user_id,username,register_date FROM users
WHERE city_id IN (
	SELECT city_id FROM cities
	WHERE name= 'VARNA'
	)
ORDER BY balance DESC

-- Потребители без наеми
SELECT TOP(5) username,balance FROM users
WHERE user_id NOT IN (SELECT user_id FROM rents)
ORDER BY balance DESC, username;

--Наеми по градовете
SELECT COUNT(*) AS 'total_rents',c.name FROM cities AS c
JOIN users AS u ON u.city_id=c.city_id
JOIN rents AS r ON r.user_id=u.user_id
GROUP BY c.name
ORDER BY total_rents DESC;

--Най-много наеми
SELECT TOP(5) COUNT(*) AS 'toral_rents',username FROM users AS u
JOIN rents AS r ON r.user_id=u.user_id
GROUP BY username
ORDER BY toral_rents DESC,username

-- Колко тротинетки не са върнати в Пловдив?
SELECT COUNT(*) AS 'not_returned' FROM cities AS c
JOIN users AS u ON u.city_id=c.city_id
JOIN rents AS r ON r.user_id=u.user_id
JOIN scooters AS s ON s.scooter_id= r.scooter_id
WHERE c.name= 'Plovdiv' AND r.is_completed=0