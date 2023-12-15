CREATE DATABASE WMS;

USE WMS;

CREATE TABLE Clients
    (
        ClientId INT PRIMARY KEY IDENTITY,
        FirstName VARCHAR(50) NOT NULL,
        LastName VARCHAR(50) NOT NULL,
        Phone VARCHAR(12) NOT NULL,
        CHECK(LEN(Phone)=12)
    );
    CREATE TABLE Mechanics
    (
        MechanicId INT PRIMARY KEY IDENTITY,
        FirstName VARCHAR(50) NOT NULL,
        LastName VARCHAR(50) NOT NULL,
        Address VARCHAR(255) NOT NULL
    );
    CREATE TABLE Models
    (
        ModelId INT PRIMARY KEY IDENTITY,
        Name VARCHAR(50) UNIQUE
    );
    CREATE TABLE Jobs
    (
        JobId INT PRIMARY KEY IDENTITY,
        ModelId INT NOT NULL,
        Status VARCHAR(11) DEFAULT 'Pending'
        CHECK(Status IN ('Pending', 'In Progress', 'Finished')),
        ClientId INT NOT NULL,
        MechanicId INT,
        IssueDate DATETIME2 NOT NULL,
        FinishDate DATETIME2
        CONSTRAINT fk_jobs_models
            FOREIGN KEY(ModelId)
            REFERENCES Models(ModelId),
        CONSTRAINT fk_jobs_clients
            FOREIGN KEY(ClientId)
            REFERENCES Clients(ClientId),
        CONSTRAINT fk_jobs_mechanics
            FOREIGN KEY(MechanicId)
            REFERENCES Mechanics(MechanicId)
    );
    CREATE TABLE Orders
    (
        OrderId INT PRIMARY KEY IDENTITY,
        JobId INT NOT NULL,
        IssueDate DATETIME2,
        Delivered TINYINT DEFAULT 0
        CONSTRAINT fk_orders_jobs
            FOREIGN KEY(JobId)
            REFERENCES Jobs(JobId)
    );
    CREATE TABLE Vendors
    (
        VendorId INT PRIMARY KEY IDENTITY,
        Name VARCHAR(50) NOT NULL UNIQUE
    );
    CREATE TABLE Parts
    (
        PartId INT PRIMARY KEY IDENTITY,
        SerialNumber VARCHAR(50) NOT NULL UNIQUE,
        Description VARCHAR(255),
        Price DECIMAL(6,2) NOT NULL,
        CHECK(PRICE>0 AND Price<=9999.99),
        VendorId INT NOT NULL,
        StockQty INT NOT NULL DEFAULT 0
        CONSTRAINT fk_parts_vendors
            FOREIGN KEY(VendorId)
            REFERENCES Vendors(VendorId)
    );
    CREATE TABLE OrderParts
    (
        OrderId INT NOT NULL,
        PartId INT NOT NULL,
        Quantity INT NOT NULL DEFAULT 1,
        CHECK(Quantity>=0),
        CONSTRAINT pk_orderid_partid
            PRIMARY KEY(OrderId,PartId),
        CONSTRAINT fk_orderparts_orders
            FOREIGN KEY(OrderId)
            REFERENCES Orders(OrderId),
        CONSTRAINT fk_orderparts_parts
            FOREIGN KEY(PartId)
            REFERENCES Parts(PartId)
    );
    CREATE TABLE PartsNeeded
    (
        JobId INT NOT NULL,
        PartId INT NOT NULL,
        Quantity INT NOT NULL DEFAULT 1,
        CHECK(Quantity>=0),
        CONSTRAINT pk_jobid_partid
            PRIMARY KEY(JobId,PartId),
        CONSTRAINT fk_partsneeded_jobs
            FOREIGN KEY(JobId)
            REFERENCES Jobs(JobId),
        CONSTRAINT fk_partsneeded_parts
            FOREIGN KEY(PartId)
            REFERENCES Parts(PartId)
    );