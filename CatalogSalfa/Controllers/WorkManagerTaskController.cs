using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    [ApiController]
    [Route("workManagerTask")]
    public class WorkManagerTaskController : ControllerBase
    {
        private readonly IWorkManagerTask service;

        public WorkManagerTaskController(IWorkManagerTask service)
        {
            this.service = service;
        }

        //GET /workManagerTask 
        [HttpGet("{projectId}/{activityId}")]
        public Task<List<WorkManagerTask>> GetWorkManagerTasks(int projectId, int activityId)
        {
            var workManagerTask = service.GetWorkManagerTasksAsync(projectId, activityId);
            return workManagerTask;
        }

    }
}