using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    [ApiController]
    [Route("reason")]
    public class ReasonController : ControllerBase
    {
        private readonly IReason service;

        public ReasonController(IReason service)
        {
            this.service = service;
        }

        [HttpGet("workspaceId")]
        public Task<List<Reason>> GetReasons(int workspaceId)
        {
            var reason = service.GetReasonAsync(workspaceId);
            return reason;
        }

    }
}