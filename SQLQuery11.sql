CREATE TABLE ClientInfo(ClientId INT IDENTITY (1,1),ClientName varchar(25),
ClientNumber varchar(20),ClientEmail varchar(30),ClientPassword varchar(40),ClientGenderId int,ClientDOB DATETIME)

CREATE TABLE ClientGender(ClientGenderId INT IDENTITY(1,1),ClientGenderName varchar(20))

CREATE TABLE CategoryType(CategoryId INT IDENTITY(1,1),CategoryName varchar(50))

CREATE TABLE ItemType(ItemId INT IDENTITY(1,1),ItemName varchar(50),ItemPrice float ,CategoryId int)

CREATE TABLE Bill(BillId INT IDENTITY(1,1),ItemId int ,ItemQuantity int,ClientId int,PaymentTypeId int,CreatedOn datetime default getdate())

CREATE TABLE PaymentType(PaymentTypeId INT IDENTITY(1,1),PaymentName varchar(40))