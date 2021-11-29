using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IWorkspace
    {
        Task<List<Workspace>> GetWorkspaceAsync();
    }

}