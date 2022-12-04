CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL constraint PK_Emplyees PRIMARY KEY identity(1,1),
	[Name] nvarchar(64) not null,
	[SuperiorId] int not null constraint FK_Employees_SuperiorId_Employees_Id foreign key (SuperiorId) references Employees(Id)
)
