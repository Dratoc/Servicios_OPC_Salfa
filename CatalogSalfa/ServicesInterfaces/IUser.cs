using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IUser
    {
        Task<User> GetUserAsync(int userId);
    }
}