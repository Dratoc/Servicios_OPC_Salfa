using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IProject
    {
        Task<List<Project>> GetProjectsAsync();
    }
}