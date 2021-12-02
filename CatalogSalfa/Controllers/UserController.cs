using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUser service;

        public UserController(IUser service)
        {
            this.service = service;
        }

        [HttpGet("userId")]
        public Task<User> GetUser(int userId)
        {
            var user = service.GetUserAsync(userId);
            return user;
        }

    }
}