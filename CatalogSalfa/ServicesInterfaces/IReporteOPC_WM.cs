using CatalogSalfa.Dtos;

namespace CatalogSalfa.ServicesInterfaces
{
    public interface IReporteOPC_WM
    {
        Task<ReporteOPC_WM> GetReporteOPC_WMs(string code);
    }
}