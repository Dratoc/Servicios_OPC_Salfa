using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IWorkManagerTask
    {
        Task<List<WorkManagerTask>> GetWorkManagerTasksAsync(int projectId, int activityId);
        Task<List<WorkManagerTask>> GetWorkManagerTasksAsyncToken(int projectId, int activityId, Token token);
    }
}