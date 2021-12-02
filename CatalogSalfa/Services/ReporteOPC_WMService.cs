using CatalogSalfa.Dtos;
using CatalogSalfa.ServicesInterfaces;

namespace CatalogSalfa.Services
{
    public class ReporteOPC_WMService : IReporteOPC_WM
    {
        public async Task<ReporteOPC_WM> GetReporteOPC_WMs(string code)
        {

            ProjectService serviceProject = new ProjectService();

            var projects = await serviceProject.GetProjectsAsync(code);

            ReporteOPC_WM reporte = new ReporteOPC_WM()
            {
                projects = projects
            };

            return reporte;

        }
    }
}