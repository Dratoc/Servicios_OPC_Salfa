using CatalogSalfa.Dtos;
using CatalogSalfa.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatalogSalfa.Controllers
{

    [ApiController]
    [Route("ReporteOPC_WM")]
    public class ReporteOPC_WMController : ControllerBase
    {
        public readonly IReporteOPC_WM service;

        public ReporteOPC_WMController(IReporteOPC_WM service)
        {
            this.service = service;
        }

        [HttpGet("code")]
        public Task<ReporteOPC_WM> GetReporteOPC_WM(string code)
        {
            try
            {
                var reporte = service.GetReporteOPC_WMs(code);

                return reporte;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

    }
}