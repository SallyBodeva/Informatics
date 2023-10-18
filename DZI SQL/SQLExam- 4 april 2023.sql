Create database Accounting1;

Use Accounting1;

Create table Countries
(
	id int primary key identity,
	[name] nvarchar(10) not null
);
Create table Addresses
(
	id int primary key identity,
	StreetName nvarchar(20) not null,
	StreetNumber int,
	PostCode int not null,
	City varchar(25) not null,
	countryId int not null,
		constraint fk_Addresses_Countries
			foreign key (countryId)
			references Countries(id)
);

Create table Vendors
(
	id int primary key identity,
	[name] nvarchar(25) not null,
	NumberVat nvarchar(15) not null,
	AddressId int not null,
		constraint fk_Vendors_Addresses
			foreign key (AddressId)
			references Addresses(id)
);

Create table Clients
(
	id int primary key identity,
	name nvarchar(25) not null,
	NumberVat nvarchar(25) not null,
	AddressId int not null,
		constraint fk_Clients_Addresses
		foreign key(AddressId)
		references Addresses(id)
);

Create table Categories
(
	id int primary key identity,
	name nvarchar(10) not null
);

Create table Products
(
	id int primary key identity,
	name nvarchar(35) not null,
	price decimal(18,2) not null,
	catrgoryId int not null,
	vendorId int not null,
		constraint fk_Products_Categories
		foreign key (catrgoryId)
		references Categories(id),
		constraint fk_Products_Vendors
		foreign key (vendorId)
		references Vendors(id)
);

Create table Invoices
(
	id int primary key identity,
	number int unique not null,
	IssueDate DateTime2 not null,
	DueDate DateTime2 not null,
	Amount  decimal(18,2) not null,
	Currency varchar(5) not null,
	ClientId int  not null,
		constraint fk_Invoices_Clients
		foreign key (ClientId)
		references Clients(id)
);

Create table ProductsClients
(
	productId int not null,
	clientId int not null,
		constraint pk_ProductsClients
			primary key (productId,clientId),
		constraint fk_ProductsClients_Products
			foreign key (productId)
			references Products(id),
		constraint fk_ProductsClients_Clients
			foreign key (clientId)
			references Clients(id),
);