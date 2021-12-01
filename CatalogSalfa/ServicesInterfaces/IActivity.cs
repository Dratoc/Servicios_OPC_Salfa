using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IActivity
    {
        Task<Activity> GetActivityAsync(int activityId);
    }
}