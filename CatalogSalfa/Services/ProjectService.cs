using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class ProjectService : IProject
    {

        private static string url = "https://primavera.oraclecloud.com/api/restapi/project/code/";

        public async Task<List<Project>> GetProjectsAsync(string ProjectCode)
        {

            HttpClient client = new HttpClient();

            TokenService tokenService = new TokenService();
            var token = await tokenService.GetTokenAsync();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
            client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
            client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.GetAsync(url + ProjectCode);

            List<Project> listProjects = new List<Project>();

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                listProjects = JsonSerializer.Deserialize<List<Project>>(json);
            }

            return listProjects;
        }
    }
}