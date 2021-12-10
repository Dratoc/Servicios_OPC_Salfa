namespace CatalogSalfa.Entities
{
    public class CodeValue
    {
        public int constraintId { get; set; }
        public int codeValueConstraintId { get; set; }
        public int sequenceNumber { get; set; }
        public string codeTypeCode { get; set; }
        public int parentId { get; set; }
        public int codeTypeId { get; set; }
        public string codeValueCode { get; set; }
        public int codeValueId { get; set; }
        public string codeValueName { get; set; }
        public DateTime updateDate { get; set; }
    }

    public class TaskConstraint
    {
        public int constraintId { get; set; }
        public int workManagerTaskId { get; set; }
        public int taskConstraintId { get; set; }
        public DateTime updateDate { get; set; }
    }

    public class Constraint
    {
        public string projectCompanyColor { get; set; }
        public string constraintCode { get; set; }
        public string constraintType { get; set; }
        public int userId { get; set; }
        public string status { get; set; }
        public int projectId { get; set; }
        public string projectCode { get; set; }
        public List<CodeValue> codeValues { get; set; }
        public string workspaceCode { get; set; }
        public int constraintId { get; set; }
        public int projectCompanyId { get; set; }
        public List<TaskConstraint> taskConstraints { get; set; }
        public DateTime dateIdentified { get; set; }
        public DateTime dateNeeded { get; set; }
        public DateTime promisedDate { get; set; }
        public string constraintName { get; set; }
        public DateTime updateDate { get; set; }
    }
}