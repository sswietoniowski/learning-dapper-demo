CREATE TABLE [dbo].[TaskItems]
(
	[Id] INT NOT NULL constraint PK_TaskItems PRIMARY KEY identity(1,1),
	[Title] nvarchar(128) not null,
	[Description] nvarchar(max) null,
	[ProjectId] int not null constraint FK_TaskItems_ProjectId_Projects_Id foreign key (ProjectId) references Projects(Id),
	[AssignedToId] int null constraint FK_TaskItems_AssignedToId_Employees_Id foreign key (AssignedToId) references Employees(Id)
)
