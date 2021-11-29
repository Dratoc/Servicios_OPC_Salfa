namespace CatalogSalfa.Entities
{
    public class RequestHeaders
    {

        public string? XPrimeTenant { get; set; }

        public string? XPrimeIdentityApp { get; set; }

        public string? XPrimeRegion { get; set; }
    }

    public class Token
    {
        public string? accessToken { get; set; }
        public string? primeTenant { get; set; }
        public string? primeTenantCode { get; set; }
        public string? userName { get; set; }
        public string? userId { get; set; }
        public string? primeIdentityApp { get; set; }
        public int? expiresIn { get; set; }
        public RequestHeaders? requestHeaders { get; set; }
    }
}