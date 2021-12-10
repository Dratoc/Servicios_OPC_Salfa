using System.Text.Json;
using CatalogSalfa.Dtos;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class ProjectService : IProject
    {

        private static string url = "https://primavera.oraclecloud.com/api/restapi/project/code/";

        public async Task<List<Project>> GetProjectsAsync(string ProjectCode)
        {
            List<Project> listProjects = new List<Project>();

            try
            {
                HttpClient client = new HttpClient();

                TokenService tokenService = new TokenService();
                var token = await tokenService.GetTokenAsync();

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
                client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
                client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(url + ProjectCode);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listProjects = JsonSerializer.Deserialize<List<Project>>(json);
                }

                return listProjects;
            }
            catch (System.Exception)
            {
                return listProjects;
            }

        }

        public async Task<List<Project>> GetProjectsAsyncToken(string ProjectCode, Token token)
        {
            List<Project> listProjects = new List<Project>();

            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
                client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
                client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(url + ProjectCode);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    listProjects = JsonSerializer.Deserialize<List<Project>>(json);
                }

                return listProjects;
            }
            catch (System.Exception)
            {
                return listProjects;
            }

        }

    }
}