

USE master;
GO

IF DB_ID('Sodv2101_BudgetAppDB') IS NOT NULL
BEGIN
	ALTER DATABASE Sodv2101_BudgetAppDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE

	DROP DATABASE Sodv2101_BudgetAppDB;
END;
GO

CREATE DATABASE Sodv2101_BudgetAppDB;
GO



USE Sodv2101_BudgetAppDB;
GO

CREATE TABLE IncomeType (
	
	TypeID INT PRIMARY KEY IDENTITY(1,1),
	Type VARCHAR(50) NOT NULL,

);


CREATE TABLE Users (

	UserID INT PRIMARY KEY IDENTITY(1,1),
	FirstName VARCHAR(50) NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	Email VARCHAR(75) NOT NULL,
	Password VARCHAR(50) NOT NULL

);

CREATE TABLE Income (

	IncomeID INT PRIMARY KEY IDENTITY(1,1),
	Amount MONEY NOT NULL,
	TimePeriod VARCHAR(50) NOT NULL,
	IncomeTypeID INT NOT NULL,
	UserID INT NOT NULL,

	FOREIGN KEY (IncomeTypeID) REFERENCES IncomeType(TypeID) ON DELETE NO ACTION ON UPDATE NO ACTION,
	FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE NO ACTION ON UPDATE NO ACTION
);


CREATE TABLE HoursWorked (

	HoursID INT PRIMARY KEY IDENTITY(1,1),
	[Hours] DECIMAL(6,2) NOT NULL,
	Date DATE,
	IncomeID INT NOT NULL,

	FOREIGN KEY (IncomeID) REFERENCES Income(IncomeID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE Budget (

	BudgetID INT PRIMARY KEY IDENTITY(1,1),
	BudgetName VARCHAR(100) NOT NULL,
	MaxAmount MONEY NOT NULL,
	Description VARCHAR(255) NULL,
	UserID INT NOT NULL,

	FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE NO ACTION ON UPDATE NO ACTION


);


CREATE TABLE Expense (

	ExpenseID INT PRIMARY KEY IDENTITY(1,1),
	BudgetID INT NOT NULL, 
	Amount MONEY NOT NULL,
	Description VARCHAR(255) NULL,
	PurchaseDate DATE NULL,

	FOREIGN KEY (BudgetID) REFERENCES Budget(BudgetID) ON DELETE NO ACTION ON UPDATE NO ACTION

);

CREATE TABLE FinancialGoal (

	GoalID INT PRIMARY KEY IDENTITY(1,1),
	Amount MONEY NOT NULL,
	Description VARCHAR(255) NULL,
	Deadline DATE NULL,
	UserID INT NOT NULL, 

	FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE NO ACTION ON UPDATE NO ACTION
);

CREATE TABLE Contribution (

	ContributionID INT PRIMARY KEY IDENTITY(1,1),
	GoalID INT NOT NULL,
	Amount MONEY NOT NULL,
	Description VARCHAR(255) NULL

	FOREIGN KEY (GoalID) REFERENCES FinancialGoal(GoalID) ON DELETE NO ACTION ON UPDATE NO ACTION

);



