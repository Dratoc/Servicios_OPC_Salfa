using System.Text;
using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{

    public class WorkspaceService : IWorkspace
    {
        private readonly string url = "https://primavera.oraclecloud.com/api/restapi/workspace";

        private static HttpClient client = new HttpClient();

        List<Workspace> workspace = new List<Workspace>();

        public async Task<List<Workspace>> GetWorkspaceAsync()
        {
            TokenService tokenService = new TokenService();
            var token = await tokenService.GetTokenAsync();
            Workspace workspaceAux = new Workspace();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
            client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
            client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            //client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            //var data = new StringContent("", Encoding.UTF8, "application/json");

            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                workspace = JsonSerializer.Deserialize<List<Workspace>>(json);
            }

            return workspace;
        }
    }
}