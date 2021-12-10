namespace CatalogSalfa.Entities
{
    public class Reason
    {
        public string reasonName { get; set; }
        public int reasonId { get; set; }
        public int workspaceId { get; set; }
        public string workspaceCode { get; set; }
        public DateTime updateDate { get; set; }
        public string abbreviation { get; set; }
    }

    public class WorkManagerTaskCommitment
    {
        public string companyPostalCode { get; set; }
        public string projectCompanyColor { get; set; }
        public int addByUserId { get; set; }
        public string workManagerTaskCode { get; set; }
        public int workManagerTaskCommitmentId { get; set; }
        public string status { get; set; }
        public int projectId { get; set; }
        public string companyName { get; set; }
        public string projectCode { get; set; }
        public string workspaceCode { get; set; }
        public List<Reason> reasons { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime createDate { get; set; }
        public int applicationUserId { get; set; }
        public int workManagerTaskId { get; set; }
        public string comments { get; set; }
        public int projectCompanyId { get; set; }
        public string timezoneDateAdded { get; set; }
        public DateTime updateDate { get; set; }
    }

}