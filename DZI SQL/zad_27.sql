CREATE DATABASE hospital;

USE hospital;

CREATE TABLE departments
(
	id INT PRIMARY KEY IDENTITY,
	department_name NVARCHAR(255) NOT NULL,
	count_beds INT NOT NULL
);

CREATE TABLE patients
(
	id INT PRIMARY KEY IDENTITY,
	name NVARCHAR(255) NOT NULL,
	age INT NOT NULL,
	diagnosis NVARCHAR(255) NOT NULL,
	department_id INT NOT NULL,
		CONSTRAINT fk_patients_departments
			FOREIGN KEY (department_id)
			REFERENCES departments(id)
);

INSERT INTO departments(department_name,count_beds)
VALUES
('хирургия',25),
('ортопедия',18),
('педиатрия',35),
('офталмология',20);

INSERT INTO patients(name,age,diagnosis,department_id)
VALUES
('Мирослав Славов',36,'луксация',2),
('Ния Христова',4,'оптит',3),
('Никола Попов',67,'катаракта',4),
('Мира Данаилова',27,'фрактура',2),
('Свилен Койчев',53,'харния',1),
('Христиан Митев',12,'пневмония',3);

SELECT name,diagnosis FROM patients AS p
JOIN departments AS d ON d.id=p.department_id
WHERE p.age>=20 AND p.age<=60
ORDER BY p.age DESC;


SELECT name,age,d.department_name FROM patients AS p
JOIN departments AS d ON d.id=p.department_id;

SELECT d.id, COUNT(*) AS 'people count' FROM patients AS p
JOIN departments AS d ON d.id=p.department_id
GROUP BY d.id
ORDER BY COUNT(*);