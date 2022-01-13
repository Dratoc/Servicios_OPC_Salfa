namespace CatalogSalfa.Entities
{
    /*    public class UserSetting
    {
        public string @namespace { get; set; }
        public string settingName { get; set; }
        public object settingValue { get; set; }
        public int applicationUserId { get; set; }
        public int applicationUserSettingId { get; set; }
        public DateTime updateDate { get; set; }
    }

    public class UserProduct
    {
        public string productName { get; set; }
        public int productId { get; set; }
        public int userProductId { get; set; }
        public int applicationUserId { get; set; }
        public DateTime updateDate { get; set; }
    }*/

    public class User
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool restrictedUser { get; set; }
        public string userName { get; set; }
        public string status { get; set; }
        public string ldapGuid { get; set; }
        public int companyId { get; set; }
        public string mobile { get; set; }
        public string phone { get; set; }
        public string alternateEmail { get; set; }
        //public List<UserSetting> userSettings { get; set; }
        //public List<UserProduct> userProducts { get; set; }
        public bool isInspectionManager { get; set; }
        public bool receiveReports { get; set; }
    }



}