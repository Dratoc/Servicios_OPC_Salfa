using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IWorkManagerTaskCommitment
    {
        Task<List<WorkManagerTaskCommitment>> GetWorkManagerTaskCommitmentAsync(int workManagerTaskId);

        Task<List<WorkManagerTaskCommitment>> GetWorkManagerTaskCommitmentAsyncToken(int workManagerTaskId, Token token);
    }

}