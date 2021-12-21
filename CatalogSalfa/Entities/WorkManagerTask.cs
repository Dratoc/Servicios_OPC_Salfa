namespace CatalogSalfa.Entities
{
    public class ConfiguredField
    {
        public int workManagerTaskConfiguredFieldValueId { get; set; }
        public string columnName { get; set; }
        public int numberValue { get; set; }
        public int columnDefinitionId { get; set; }
        public string columnLabel { get; set; }
        public int workManagerTaskId { get; set; }
        public bool hasException { get; set; }
        public DateTime updateDate { get; set; }
        public string textValue { get; set; }
    }

    public class WorkManagerTask
    {
        public string workManagerTaskName { get; set; }
        public bool favorite { get; set; }
        //public string companyPostalCode { get; set; }
        //public string projectCompanyColor { get; set; }
        public int sequenceNumber { get; set; }
        public string type { get; set; }
        public int userId { get; set; }
        public string status { get; set; }
        public int project { get; set; }
        public string companyName { get; set; }
        public string projectCode { get; set; }
        //public List<object> codeValues { get; set; }
        public DateTime startDate { get; set; }
        public string workspaceCode { get; set; }
        public bool overdue { get; set; }
        public int activityId { get; set; }
        public string itemCode { get; set; }
        public string visibility { get; set; }
        public string itemPrefix { get; set; }
        public int itemSuffix { get; set; }
        public int workManagerTaskId { get; set; }
        public double durationHours { get; set; }
        public DateTime tentativeDate { get; set; }
        public bool useCalendar { get; set; }
        public DateTime latestCommitmentDueDate { get; set; }
        public DateTime originalCommitmentDueDate { get; set; }
        public string activityDateStatus { get; set; }
        public string activityCompleteStatus { get; set; }
        public int commitmentCount { get; set; }
        public double slack { get; set; }
        public int predecessorCount { get; set; }
        public int successorCount { get; set; }
        public bool isDueThisWeek { get; set; }
        public bool hasSlack { get; set; }
        public bool hasCommitments { get; set; }
        public bool isUnassigned { get; set; }
        public bool isPending { get; set; }
        public bool isUnplanned { get; set; }
        public bool isOutsideActivity { get; set; }
        public bool isSchNonWorkDays { get; set; }
        public bool isOverdue { get; set; }
        public bool hasProposedDueDate { get; set; }
        public int projectCompanyId { get; set; }
        public List<ConfiguredField> configuredFields { get; set; }
        public DateTime updateDate { get; set; }
        public List<WorkManagerTaskCommitment> workManagerTaskCommitment { get; set; }
        public List<Constraint> constraint { get; set; }
        public User user { get; set; }
    }




}