using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    [ApiController]
    [Route("workManagerTaskCommitment")]
    public class WorkManagerTaskCommitmentController : ControllerBase
    {
        private readonly IWorkManagerTaskCommitment service;

        public WorkManagerTaskCommitmentController(IWorkManagerTaskCommitment service)
        {
            this.service = service;
        }

        [HttpGet("workManagerTaskId")]
        public Task<List<WorkManagerTaskCommitment>> GetWorkManagerTaskCommitment(int workManagerTaskId)
        {
            var workManagerTaskCommitment = service.GetWorkManagerTaskCommitmentAsync(workManagerTaskId);
            return workManagerTaskCommitment;
        }

    }
}