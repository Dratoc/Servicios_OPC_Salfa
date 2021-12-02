using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{


    [ApiController]
    [Route("constraint")]
    public class ConstraintController : ControllerBase
    {
        private readonly IConstraint service;

        public ConstraintController(IConstraint service)
        {
            this.service = service;
        }

        [HttpGet("projectId")]
        public Task<List<Constraint>> GetConstraints(int projectId)
        {
            var constraint = service.GetConstraintsAsync(projectId);
            return constraint;
        }

    }
}