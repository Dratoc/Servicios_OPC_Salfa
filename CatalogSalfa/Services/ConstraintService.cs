using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class ConstraintService : IConstraint
    {
        private static string url = "https://primavera.oraclecloud.com/api/restapi/constraint/workManagerTask/";

        public async Task<List<Constraint>> GetConstraintsAsync(int workManagerTaskId)
        {
            List<Constraint> listConstraint = new List<Constraint>();
            try
            {
                TokenService service = new TokenService();
                var token = await service.GetTokenAsync();

                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
                client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
                client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(url + workManagerTaskId);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listConstraint = JsonSerializer.Deserialize<List<Constraint>>(json);

                }

                return listConstraint;

            }
            catch (System.Exception)
            {
                return listConstraint;
            }

        }
        public async Task<List<Constraint>> GetConstraintsAsyncToken(int workManagerTaskId, Token token)
        {
            List<Constraint> listConstraint = new List<Constraint>();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
                client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
                client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(url + workManagerTaskId);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listConstraint = JsonSerializer.Deserialize<List<Constraint>>(json);

                }

                return listConstraint;

            }
            catch (System.Exception)
            {
                return listConstraint;
            }

        }
    }
}