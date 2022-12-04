set identity_insert dbo.Employees on;

insert into dbo.Employees
(Id, Name, SuperiorId)
values
(1, 'John Doe', 1),
(2, 'Jane Doe', 1),
(3, 'Joe Doe', 1);

set identity_insert dbo.Employees off;

insert into dbo.Managers
(Id)
values
(1);

set identity_insert dbo.Projects on;

insert into dbo.Projects
(Id, Title, Description, ManagerId)
values
(1, 'Project 1', 'Project 1 Description', 1),
(2, 'Project 2', 'Project 2 Description', 1);

set identity_insert dbo.Projects off;

set identity_insert dbo.TaskItems on;

insert into dbo.TaskItems
(Id, Title, Description, ProjectId, AssignedToId)
values
(1, 'Task 1', 'Task 1 Description', 1, 2),
(2, 'Task 2', 'Task 2 Description', 1, null),
(3, 'Task 3', 'Task 3 Description', 2, 3),
(4, 'Task 4', 'Task 4 Description', 2, null);

set identity_insert dbo.TaskItems off;
