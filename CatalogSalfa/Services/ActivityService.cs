using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using System.Text.Json;

namespace CatalogSalfa.Services
{

    public class ActivityService : IActivity
    {

        private readonly string url = "https://primavera.oraclecloud.com/api/restapi/activity/project/";

        public async Task<List<Activity>> GetActivityAsync(int projectId)
        {

            List<Activity> activities = new List<Activity>();

            try
            {
                HttpClient client = new HttpClient();

                TokenService tokenService = new TokenService();

                var token = await tokenService.GetTokenAsync();

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
                client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
                client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(url + projectId);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    activities = JsonSerializer.Deserialize<List<Activity>>(json);

                    var serializeOptions = new JsonSerializerOptions();
                }

                return activities;
            }
            catch (System.Exception)
            {
                return activities;
            }
        }

        public async Task<List<Activity>> GetActivityAsyncToken(int projectId, Token token)
        {

            List<Activity> activities = new List<Activity>();

            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
                client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
                client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                var response = await client.GetAsync(url + projectId);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    activities = JsonSerializer.Deserialize<List<Activity>>(json);

                    var serializeOptions = new JsonSerializerOptions();
                }

                List<Activity> filterActivities = new List<Activity>();

                for (int i = 0; i < activities.Count; i++)
                {
                    if (activities[i].workManagerTaskCount > 0)
                    {
                        filterActivities.Add(activities[i]);
                    }
                }

                return filterActivities;
            }
            catch (System.Exception)
            {
                return activities;
            }


        }

    }
}