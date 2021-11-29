using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    // Get /Token
    [ApiController]
    [Route("token")]
    public class TokenController : ControllerBase
    {
        private readonly IToken service;

        public TokenController(IToken service)
        {
            this.service = service;
        }

        // Get /token        
        [HttpGet]
        public Task<Token> GetToken()
        {
            var items = service.GetTokenAsync();
            return items;
        }

    }

}