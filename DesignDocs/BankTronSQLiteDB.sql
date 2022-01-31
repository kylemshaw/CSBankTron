CREATE TABLE Category
(
	ID int identity(1,1),
	Name varchar(40) not null,
	CONSTRAINT Category_PK PRIMARY KEY(ID)
);

CREATE TABLE CategoryDescription
(
	ID int identity(1,1),
	CategoryID int not null,
	Description varchar(100) not null,
	CONSTRAINT CatDesc_PK PRIMARY KEY(ID),
	CONSTRAINT CatDesc_Category_FK FOREIGN KEY (CategoryID) REFERENCES Category(ID)
);

CREATE TABLE Budget
(
	ID int identity(1,1),
	Name varchar(50) not null,
	BudgetGoalAmount money null,
	IncomeAmount money null,
	CONSTRAINT Budget_PK PRIMARY KEY(ID)
);

CREATE TABLE BudgetGroup
(
	ID int identity(1,1),
	BudgetID int not null,
	Name varchar(40) not null,
	GroupGoalAmount money null,
	CONSTRAINT BudgetGroup_PK PRIMARY KEY(ID),
	CONSTRAINT BudgetGroup_Budget_FK FOREIGN KEY (BudgetID) REFERENCES Budget(ID)
);

CREATE TABLE BudgetItem
(
	ID int identity(1,1),
	BudgetGroupID int not null,
	CategoryID int not null,
	ItemGoalAmount money null,
	CONSTRAINT BudgetItem_PK PRIMARY KEY(ID),
	CONSTRAINT BudgetItem_BudgetGroup_FK FOREIGN KEY (BudgetGroupID) REFERENCES BudgetGroup(ID),
	CONSTRAINT BudgetItem_Category_FK FOREIGN KEY (CategoryID) REFERENCES Category(ID)
);

CREATE TABLE [Transaction]
(
	ID int identity(1,1),
	CategoryID int not null,
	Bank varchar(20) null,
	AccountType varchar(20) null,
	AccountNumber varchar(20) not null,
	TransactionDate datetime not null,
	Description varchar(100) null,
	Amount money not null,
	Tags varchar(100) null,
	CONSTRAINT Transaction_PK PRIMARY KEY(ID),
	CONSTRAINT Trans_Category_FK FOREIGN KEY (CategoryID) REFERENCES Category(ID)
);
