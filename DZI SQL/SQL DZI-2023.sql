Create database Music;

Use Music;

Create table Singers
(
	id int primary key identity,
	name nvarchar(50) not null,
	songs int not null,
	[rank] int not null,
	net_worht int not null
);
Insert into Singers (name,songs,rank,net_worht)
Values
('Ivan Ivanov', 50, 1, 1000000),
('Maria Ivanova', 55 ,3, 900000),
('Georgi Georgiev', 20, 4, 800000),
('Gergana Petrova', 55, 2, 1000000),
('Boris Borisov', 20, 5, 900000);

Select Top(3) name, rank from Singers
order by [rank];

Select SUM(songs), AVG(net_worht) from Singers;

Update Singers
Set  net_worht= net_worht*1.1
where id between 2 and 4;

