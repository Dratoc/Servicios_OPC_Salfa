using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;
using System.Text.Json;

namespace CatalogSalfa.Services
{

    public class ActivityService : IActivity
    {

        private readonly string url = "https://primavera.oraclecloud.com/api/restapi/activity/";

        public async Task<Activity> GetActivityAsync(int activityId)
        {

            HttpClient client = new HttpClient();

            TokenService tokenService = new TokenService();

            var token = await tokenService.GetTokenAsync();

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token.accessToken);
            client.DefaultRequestHeaders.Add("x-prime-tenant", token.primeTenant);
            client.DefaultRequestHeaders.Add("x-prime-identity-app", token.primeIdentityApp);
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var response = await client.GetAsync(url + activityId);

            Activity activity = new Activity();

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                activity = JsonSerializer.Deserialize<Activity>(json);

                var serializeOptions = new JsonSerializerOptions();

            }

            return activity;
        }

    }
}