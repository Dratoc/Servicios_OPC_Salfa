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
        [HttpGet("projectId")]
        public Task<List<WorkManagerTask>> GetWorkManagerTasks(int projectId)
        {
            var workManagerTask = service.GetWorkManagerTasksAsync(projectId);
            return workManagerTask;
        }

    }
}