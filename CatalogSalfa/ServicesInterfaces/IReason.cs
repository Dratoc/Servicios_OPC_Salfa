using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IReason
    {
        Task<List<Reason>> GetReasonAsync(int workspaceId);
    }

}