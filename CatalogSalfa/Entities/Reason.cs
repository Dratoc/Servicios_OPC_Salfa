namespace CatalogSalfa.Entities
{
    public class Reason
    {
        public string reasonName { get; set; }
        public int reasonId { get; set; }
        public int workspaceId { get; set; }
        public string workspaceCode { get; set; }
        public string associationType { get; set; }
        public DateTime updateDate { get; set; }
        public string pushDownType { get; set; }
        public string abbreviation { get; set; }
        public List<string> appliesTo { get; set; }
    }

}