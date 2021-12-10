using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    [ApiController]
    [Route("activity")]
    public class ActivityController : ControllerBase
    {

        private readonly IActivity service;

        public ActivityController(IActivity service)
        {
            this.service = service;
        }

        //Get /activities
        [HttpGet("projectId")]
        public Task<List<Activity>> GetActivity(int projectId)
        {
            var activity = service.GetActivityAsync(projectId);
            return activity;
        }

    }
}