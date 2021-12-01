using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{
    // Get /Token
    [ApiController]
    [Route("workspace")]
    public class WorkspaceController : ControllerBase
    {
        private readonly IWorkspace service;

        public WorkspaceController(IWorkspace service)
        {
            this.service = service;
        }

        // Get /token        
        [HttpGet]
        public Task<List<Workspace>> GetWorkspace()
        {
            var workspace = service.GetWorkspaceAsync();
            return workspace;
        }

    }
}