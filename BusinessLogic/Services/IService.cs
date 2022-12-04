using BusinessLogic.ViewModels;

namespace BusinessLogic.Services;

public interface IService
{
    Task<IEnumerable<ProjectSummaryVM>> GetAllProjectsAsync();
}