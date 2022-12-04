CREATE TABLE [dbo].[Projects]
(
	[Id] INT NOT NULL constraint PK_Projects PRIMARY KEY identity(1,1),
	Title nvarchar(128) not null,
	Description nvarchar(max) null,
	[ManagerId] int not null constraint FK_Projects_ManagerId_Managers_Id foreign key (ManagerId) references Managers(Id)
)
