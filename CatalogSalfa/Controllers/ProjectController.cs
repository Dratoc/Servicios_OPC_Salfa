using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    [ApiController]
    [Route("project")]
    public class ProjectController : ControllerBase
    {
        private readonly IProject service;
        public ProjectController(IProject service)
        {
            this.service = service;
        }

        [HttpGet("{code}")]
        public Task<List<Project>> ProjectsAsync(string code)
        {

            var projects = service.GetProjectsAsync(code);

            return projects;
        }
    }
}