using CatalogSalfa.Entities;

namespace CatalogSalfa.Dtos
{
    public record ReporteOPC_WM
    {
        public List<Project> projects { get; init; }
    }
}