USE master
GO

CREATE DATABASE VNVC
GO

USE VNVC
GO

CREATE TABLE Account
(
	AccountID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	Email VARCHAR(200),
	FirstName NVARCHAR(100),
	LastName NVARCHAR(100),
	FullName NVARCHAR(250),
	Birthday datetime2(7),
	PhoneNumber VARCHAR(50),
	[Address] NVARCHAR(MAX),
	Avatar NVARCHAR(MAX),
	ColorAvatar VARCHAR(10),
	DefaultAvatar CHAR(1),
	InsertedDate datetime2(7),
)
GO

CREATE TABLE LotteryResults
(
	LotteryResultsID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	Slot datetime2(7),
	Result INT,
	InsertedDate datetime2(7),
)
GO

CREATE TABLE UserLottery
(
	UserLotteryID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
	AccountID UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Account(AccountID),
	Slot datetime2(7),
	Result INT,
	InsertedDate datetime2(7),
)