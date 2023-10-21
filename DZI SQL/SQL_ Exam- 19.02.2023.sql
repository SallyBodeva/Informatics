Create database Boardgames;
Use BoardGames;
-- Creation
Create table Categories
(
	id int primary key identity,
	[name] varchar(50) not null
);
Create table Addresses
(
	id int primary key identity,
	StreetName nvarchar(100) not null,
	StreetNumber int not null,
	Town varchar(30) not null,
	Country varchar(50) not null,
	ZIP int not null
);
Create table Publishers
(
	id int primary key identity,
	[name] varchar(30) not null,
	AddressId int not null,
	WebSite nvarchar(40),
	Phone nvarchar(20),
		constraint fk_Publishers_Addresses
			foreign key(AddressId)
			references Addresses(id)
);
Create table PlayersRanges
(
	id int primary key identity,
	PlayersMin int not null,
	PlayersMax int not null
);
Create table Boardgames
(
	id int primary key identity,
	[name] nvarchar(30) not null,
	YearPublished int not null,
	Rating decimal(2) not null,
	Category_Id int not null,
	Publisher_Id int not null,
	PlayersRangeId int not null,
		constraint fk_Boardgames_Categories
			foreign key (Category_Id)
			references Categories(id),
		constraint fk_Boardgames_Publishers
			foreign key (Publisher_Id)
			references Publishers(id),
		constraint fk_Boardgames_PlayersRanges
			foreign key (PlayersRangeId)
			references PlayersRanges(id),
);

Create table Creators
(
	id int primary key identity,
	FirstName nvarchar(30) not null,
	LastName nvarchar(30) not null,
	Email nvarchar(30) not null
);

Create table CreatorsBoardgames
(
	CreatorId int not null,
	BoardgameId int not null,
		constraint pk_CreatorsBoardgames
			primary key(CreatorId,BoardgameId),
		constraint fk_CreatorsBoardgames_Creators
			foreign key (CreatorId)
			references Creators(id),
		constraint fk_CreatorsBoardgames_Boardgames
			foreign key (BoardgameId)
			references Boardgames(id),

);

-- Insert
Insert into BoardGames(name, YearPublished,Rating,Category_Id,Publisher_Id,PlayersRangeId)
Values
('Deep Blue',2019,5.67,1,15,7),
('Paris',2016,9.78,7,1,5),
('Catan: Starfarers',2021,9.87,7,13,6),
('Bleeding Kansas',2020,3.25,3,7,4),
('One Small Step',2019,5.75,5,9,2);

Insert into Publishers(name,AddressId,WebSite,Phone)
Values
('Agman Games',5,'www.agmangames.com','+16546135542'),
('Amethyst Games',7,'www.amethystgames.com','+15558889992'),
('BattleBooks',13,'www.battlebooks.com','+12345678907');

--Update
Update PlayersRanges
Set PlayersMax= PlayersMax+1
where PlayersMax=2 and PlayersMin=2;

Update Boardgames
Set name= name+'V2'
where YearPublished>2020;

--Delete
Delete from Addresses
where Town like 'L%';