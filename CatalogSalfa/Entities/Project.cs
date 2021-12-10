namespace CatalogSalfa.Entities
{
    /*public class ConfiguredFieldProject
    {
        public string columnName { get; set; }
        public int projectConfiguredFieldValueId { get; set; }
        public string columnLabel { get; set; }
        public int projectId { get; set; }
        public int columnDefinitionId { get; set; }
        public bool hasException { get; set; }
        public string exceptionMessage { get; set; }
        public DateTime updateDate { get; set; }
        public string textValue { get; set; }
        public int? numberValue { get; set; }
    }

    public class ProjectSetting
    {
        public int projectId { get; set; }
        public string settingName { get; set; }
        public string settingValue { get; set; }
        public int projectSettingId { get; set; }
        public DateTime updateDate { get; set; }
    }*/

    public class ProjectFinancial
    {
        public int projectId { get; set; }
        public int proposedBudgetBaseUndistributed { get; set; }
        public int proposedPlannedVar { get; set; }
        public int forecastCurrApprVar { get; set; }
        public int plannedBudgetUndistributed { get; set; }
        public int forecastCostUndistributed { get; set; }
        public int benefitsUndistributed { get; set; }
        public int spendForecastVar { get; set; }
        public int currentApprovedSpendVariance { get; set; }
        public int proposedForecastVariance { get; set; }
        public int spendPlannedVariance { get; set; }
        public DateTime updateDate { get; set; }
    }

    /*public class ProjectAutoNumber
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int projectId { get; set; }
        public int projectAutoNumberId { get; set; }
        public string area { get; set; }
        public int increment { get; set; }
        public DateTime updateDate { get; set; }
    }*/

    public class Project
    {
        public int parentProject { get; set; }
        public double planDuration { get; set; }
        public int sequenceNumber { get; set; }
        public string manager { get; set; }
        public string status { get; set; }
        public List<object> projectCashFlows { get; set; }
        //public List<ConfiguredFieldProject> configuredFields { get; set; }
        public int workspaceId { get; set; }
        public int projectId { get; set; }
        //public List<ProjectSetting> projectSettings { get; set; }
        public string dataDate { get; set; }
        public string projectCode { get; set; }
        public string startDate { get; set; }
        public string planStartDate { get; set; }
        public string planEndDate { get; set; }
        public string projectName { get; set; }
        //public bool isTemplateFlag { get; set; }
        public string workspaceCode { get; set; }
        //public string projectTimeZone { get; set; }
        public int calendarId { get; set; }
        //public ProjectFinancial projectFinancial { get; set; }
        //public int projectCurrency { get; set; }
        public string projectIntegrationType { get; set; }
        public string percentCompleteWeightedBy { get; set; }
        //public string securityGuid { get; set; }
        public string finishDate { get; set; }
        //public List<ProjectAutoNumber> projectAutoNumber { get; set; }
        //public int strgyPriorityNum { get; set; }
        public List<object> codeValuesProject { get; set; }
        public double remainingDuration { get; set; }
        public DateTime remainingStartDate { get; set; }
        public DateTime remainingFinishDate { get; set; }
        //public bool linkForecastToSpend { get; set; }
        //public string plannedBudgetLinkType { get; set; }
        //public string forecastLinkType { get; set; }
        //public string actualLinkType { get; set; }
        //public string exchangeRateType { get; set; }
        public string scheduledFinishDate { get; set; }
        public int recordCount { get; set; }
        public int managerId { get; set; }
        public DateTime updateDate { get; set; }
        public List<Activity> activities { get; set; }
    }


}