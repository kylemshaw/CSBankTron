-- BankTron Database Creation
-- Author: Kyle Shaw
-- Date: NOv 13, 2021

--change focus to master
USE master
GO

--If exisitng DB with this name then delete it 
IF DB_ID('BankTron') IS NOT NULL
	DROP DATABASE BankTron

--Create database	
CREATE DATABASE BankTron
GO

--change focus to new database
USE BankTron
GO

/* Create Tables */ 

CREATE TABLE Categories
(
	ID int identity(1,1),
	Name varchar(40) not null,
	CONSTRAINT Categories_PK PRIMARY KEY(ID)
);

CREATE TABLE CategoryDescriptions
(
	ID int identity(1,1),
	CategoryID int null,
	Description varchar(100) null,
	CONSTRAINT CatDesc_PK PRIMARY KEY(ID),
	CONSTRAINT CatDesc_Category_FK FOREIGN KEY (CategoryID) REFERENCES Categories(ID)
);

CREATE TABLE Budgets
(
	ID int identity(1,1),
	Name varchar(50) not null,
	BudgetGoalAmount money null,
	IncomeAmount money null,
	CONSTRAINT Budget_PK PRIMARY KEY(ID),
);

CREATE TABLE BudgetGroups
(
	ID int identity(1,1),
	BudgetID int null,
	Name varchar(40) not null,
	GroupGoalAmount money null,
	CONSTRAINT BudgetGroup_PK PRIMARY KEY(ID),
	CONSTRAINT BudgetGroup_Budget_FK FOREIGN KEY (BudgetID) REFERENCES Budgets(ID)
);

CREATE TABLE BudgetItems
(
	ID int identity(1,1),
	BudgetGroupID int null,
	CategoryID int null,
	ItemGoalAmount money null,
	CONSTRAINT BudgetItem_PK PRIMARY KEY(ID),
	CONSTRAINT BudgetItem_BudgetGroup_FK FOREIGN KEY (BudgetGroupID) REFERENCES BudgetGroups(ID),
	CONSTRAINT BudgetItem_Category_FK FOREIGN KEY (CategoryID) REFERENCES Categories(ID)
);

CREATE TABLE Transactions
(
	ID int identity(1,1),
	BudgetGroupID int null,
	CategoryID int null,
	Bank varchar(20) null,
	AccountType varchar(20) null,
	AccountNumber varchar(20) null,
	TransactionDate datetime not null,
	Description varchar(100) null,
	Amount money not null,
	Tags varchar(100) null,
	CONSTRAINT Transaction_PK PRIMARY KEY(ID),
	CONSTRAINT Trans_BudgetGroup_FK FOREIGN KEY (BudgetGroupID) REFERENCES BudgetGroups(ID),
	CONSTRAINT Trans_Category_FK FOREIGN KEY (CategoryID) REFERENCES Categories(ID)
);


