using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{

    public class WorkManagerTaskCommitmentService : IWorkManagerTaskCommitment
    {
        private static string url = "https://primavera.oraclecloud.com/api/restapi/workManagerTaskCommitment/allCommitment/task/";

        public async Task<List<WorkManagerTaskCommitment>> GetWorkManagerTaskCommitmentAsync(int workManagerTaskId)
        {
            List<WorkManagerTaskCommitment> listWorkManagerTaskCommitment = new List<WorkManagerTaskCommitment>();

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
                    listWorkManagerTaskCommitment = JsonSerializer.Deserialize<List<WorkManagerTaskCommitment>>(json);
                }

                return listWorkManagerTaskCommitment;
            }
            catch (System.Exception)
            {
                return listWorkManagerTaskCommitment;
            }


        }

        public async Task<List<WorkManagerTaskCommitment>> GetWorkManagerTaskCommitmentAsyncToken(int workManagerTaskId, Token token)
        {
            List<WorkManagerTaskCommitment> listWorkManagerTaskCommitment = new List<WorkManagerTaskCommitment>();

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
                    listWorkManagerTaskCommitment = JsonSerializer.Deserialize<List<WorkManagerTaskCommitment>>(json);
                }

                return listWorkManagerTaskCommitment;
            }
            catch (System.Exception)
            {
                return listWorkManagerTaskCommitment;
            }


        }
    }
}