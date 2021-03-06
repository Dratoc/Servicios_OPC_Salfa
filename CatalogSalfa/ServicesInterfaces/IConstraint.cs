using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IConstraint
    {
        Task<List<Constraint>> GetConstraintsAsync(int projectId);
        Task<List<Constraint>> GetConstraintsAsyncToken(int workManagerTaskId, Token token);
    }
}