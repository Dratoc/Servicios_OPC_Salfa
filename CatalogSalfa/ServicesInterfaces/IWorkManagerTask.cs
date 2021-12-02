using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IWorkManagerTask
    {
        Task<List<WorkManagerTask>> GetWorkManagerTasksAsync(int projectId);
    }
}