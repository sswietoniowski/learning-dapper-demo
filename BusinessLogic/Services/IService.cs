using BusinessLogic.ViewModels;

namespace BusinessLogic.Services;

public interface IService
{
    IEnumerable<ProjectSummaryVM> GetAllProjects();
}