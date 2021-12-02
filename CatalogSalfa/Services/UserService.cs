using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class UserService : IUser
    {

        private static string url = "https://primavera.oraclecloud.com/api/restapi/user/";


        public async Task<User> GetUserAsync(int userId)
        {
            User user = new User();

            TokenService service = new TokenService();
            var token = await service.GetTokenAsync();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
            client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
            client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.GetAsync(url + userId);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                user = JsonSerializer.Deserialize<User>(json);
            }

            return user;

        }
    }
}