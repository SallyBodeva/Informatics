CREATE DATABASE school;
USE School;

CREATE TABLE students
(
	Id INT PRIMARY KEY NOT NULL,
	Name NVARCHAR(255) NOT NULL,
	BEL INT NOT NULL,
	English INT NOT NULL,
	Math INT NOT NULL,
	Informatics INT NOT NULL,
	IT INT NOT NULL
);
INSERT INTO students(Id,Name,BEL,English,Math,Informatics,IT)
VALUES
(1,'Антония Колева',4,5,6,5,4),
(2,'Асен Ангелов',5,5,6,4,5),
(3,'Борислав Ганев',4,4,5,5,6),
(4,'Бояна Тодорова',5,6,6,6,6),
(5,'Валери Илиев',6,6,6,6,6);

SELECT * FROM students
WHERE Id=4;

SELECT COUNT(*) AS 'StudentsCount' FROM students
WHERE Math = 6 AND Informatics = 6 AND IT = 6; 

SELECT AVG(BEL) , AVG(Math) FROM students;

SELECT (BEL+Math+English+IT+Informatics)/5 AS 'grade' FROM students
ORDER BY 'grade' DESC, Name;