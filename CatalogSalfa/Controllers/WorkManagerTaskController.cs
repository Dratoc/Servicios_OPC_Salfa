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
        [HttpGet]
        public Task<List<WorkManagerTask>> GetWorkManagerTasks()
        {

            var workManagerTask = service.GetWorkManagerTasksAsync();
            return workManagerTask;
        }

    }
}