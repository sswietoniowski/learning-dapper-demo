using BusinessLogic.ViewModels;
using DataAccess.Dao;

namespace BusinessLogic.Services;

public class Service : IService
{
    private readonly IEmployeeDao _employeeDao;
    private readonly IManagerDao _managerDao;
    private readonly IProjectDao _projectDao;
    private readonly ITaskItemDao _taskItemDao;

    public Service(IEmployeeDao employeeDao, IManagerDao managerDao, IProjectDao projectDao, ITaskItemDao taskItemDao)
    {
        _employeeDao = employeeDao;
        _managerDao = managerDao;
        _projectDao = projectDao;
        _taskItemDao = taskItemDao;
    }

    public async Task<IEnumerable<ProjectSummaryVM>> GetAllProjectsAsync()
    {
        var projects = await _projectDao.GetAllAsync();
        var managers = await _managerDao.GetAllAsync();
        var taskItems = await _taskItemDao.GetAllAsync();

        return projects.Select(p => new ProjectSummaryVM
        {
            Id = p.Id,
            Title = p.Title,
            Description = p.Description,
            ManagerName = managers.FirstOrDefault(m => m.Id == p.ManagerId)!.Name,
            NumberOfTasks = taskItems.Count(t => t.ProjectId == p.Id)
        });
    }
}