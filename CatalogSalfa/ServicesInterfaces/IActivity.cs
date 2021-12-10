using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IActivity
    {
        Task<List<Activity>> GetActivityAsync(int projectId);
        Task<List<Activity>> GetActivityAsyncToken(int projectId, Token token);
    }
}