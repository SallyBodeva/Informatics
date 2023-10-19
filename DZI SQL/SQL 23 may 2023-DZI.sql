Create database university;
Use university;

Create table Students
(
	Admission_no int primary key,
	First_name nvarchar(25) not null,
	Last_name nvarchar(25) not null,
	city nvarchar(25) not null
);

Create table Fee
(
	Admission_no int not null,
	course nvarchar(25) not null,
	amount_paid int not null,
		constraint fk_fee_students
			foreign key(Admission_no)
			references Students(Admission_no)
);

Insert into Students(Admission_no,First_name,Last_name,city)
Values
(3354,'Георги', 'Георгиев','Варна'),
(4321, 'Милена', 'Красимирова', 'Стара Загора'),
(8345,'Михаил', 'Мартинов', 'Пловдив'),
(7555,'Антонио', 'Тачев', 'СтараЗагора'),
(2135,'Мартин', 'Иванов', 'София');


Insert into Fee(Admission_no,course,amount_paid)
Values
(3354, 'Java', 2000),
(7555, 'C#', 1800),
(4321, 'SQL', 1600),
(4321, 'Java',2000),
(8345, 'C++', 1700);

Select * from Students
where Admission_no=8345;

Select Avg(amount_paid) as Average_amount from Fee;

Update Fee
Set course='Java'
where amount_paid=1800;

Select course, COUNT(*)as count from fee
Group by course;

Select First_name, last_name, course
FROM Students
LEFT JOIN fee ON Students.admission_no = fee.admission_no;