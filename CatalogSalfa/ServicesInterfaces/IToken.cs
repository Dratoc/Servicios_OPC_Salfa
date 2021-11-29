using CatalogSalfa.Entities;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IToken
    {
        Task<Token> GetTokenAsync();
    }
}