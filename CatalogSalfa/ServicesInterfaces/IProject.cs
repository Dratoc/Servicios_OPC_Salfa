using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IProject
    {
        Task<List<Project>> GetProjectsAsync(string ProjectCode);
        Task<List<Project>> GetProjectsAsyncToken(string ProjectCode, Token token);


    }
}