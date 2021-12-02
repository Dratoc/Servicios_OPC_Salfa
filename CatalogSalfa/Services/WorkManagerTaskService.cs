using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{

    public class WorkManagerTaskService : IWorkManagerTask
    {
        private static string url = "https://primavera.oraclecloud.com/api/restapi/workManagerTask/project/";

        public async Task<List<WorkManagerTask>> GetWorkManagerTasksAsync(int projectId)
        {

            List<WorkManagerTask> listWorkManagerTask = new List<WorkManagerTask>();

            TokenService tokenService = new TokenService();
            var token = await tokenService.GetTokenAsync();

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
            client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
            client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.GetAsync(url + projectId);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                listWorkManagerTask = JsonSerializer.Deserialize<List<WorkManagerTask>>(json);
            }

            return listWorkManagerTask;
        }
    }
}