CREATE TABLE [dbo].[Register]
(
	[Id] INT NOT NULL PRIMARY KEY,
	FirstName varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	EMail varchar(100) NOT NULL,
	Telephone int NOT NULL,
	Password varchar(50) NOT NULL,
	Gender char(10) NOT NULL,
	Age int NOT NULL,
	Address varchar(100) NOT NULL

)
