namespace CatalogSalfa.Entities
{
    public class WorkspaceSetting
    {
        public int workspaceId { get; set; }
        public string settingName { get; set; }
        public string settingValue { get; set; }
        public int workspaceSettingId { get; set; }
        public DateTime updateDate { get; set; }
    }

    public class WorkspaceAutonumSetting
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int workspaceId { get; set; }
        public int increment { get; set; }
        public int autonumId { get; set; }
        public DateTime updateDate { get; set; }
    }

    public class Workspace
    {
        public int sequenceNumber { get; set; }
        public int workspaceId { get; set; }
        public List<WorkspaceSetting> workspaceSettings { get; set; }
        public string workspaceName { get; set; }
        public string workspaceCode { get; set; }
        public string securityGuid { get; set; }
        public List<WorkspaceAutonumSetting> workspaceAutonumSettings { get; set; }
        public bool isProduction { get; set; }
        public bool isSysGenerated { get; set; }
        public DateTime updateDate { get; set; }
        public string parentWorkspaceCode { get; set; }
        public int? parentId { get; set; }
        public int? parentWorkspace { get; set; }
        public string description { get; set; }
    }

}