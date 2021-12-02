using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{

    public class ReasonService : IReason
    {
        private static string url = "https://primavera.oraclecloud.com/api/restapi/reason/workspace/";

        public async Task<List<Reason>> GetReasonAsync(int workspaceId)
        {

            List<Reason> listReason = new List<Reason>();

            TokenService service = new TokenService();
            var token = await service.GetTokenAsync();

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
            client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
            client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.GetAsync(url + workspaceId);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                listReason = JsonSerializer.Deserialize<List<Reason>>(json);
            }

            return listReason;

        }

    }
}