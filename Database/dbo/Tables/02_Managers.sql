CREATE TABLE [dbo].[Managers]
(
	[Id] INT NOT NULL constraint PK_Managers PRIMARY KEY,
	constraint FK_Managers_Id_Employees_Id foreign key (Id) references Employees(Id)
)
