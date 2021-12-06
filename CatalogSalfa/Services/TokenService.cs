using System.Text;
using System.Text.Json;
using CatalogSalfa.Entities;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class TokenService : IToken
    {
        private readonly string url = "https://primavera.oraclecloud.com/primediscovery/apitoken/request?scope=http://primavera.oraclecloud.com/api";
        //private static HttpClient client = new HttpClient();
        public async Task<Token> GetTokenAsync()
        {
            Token token = new Token();
            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.Add("Authorization", "Basic TVNJTFZBQFNBTEZBTU9OVEFKRVMuQ09NOlNhbGZhbW9udGFqZXMyMDIyLg==");
                var data = new StringContent("", Encoding.UTF8, "application/json");

                var response = await client.PostAsync(url, data);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    token = JsonSerializer.Deserialize<Token>(json);
                }

                return token;
            }
            catch (System.Exception)
            {

                return token;
            }

        }
    }
}