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
        [HttpGet("activityId")]
        public Task<Activity> GetActivity(int activityId)
        {
            var activity = service.GetActivityAsync(activityId);
            return activity;
        }

    }
}