namespace MovieTicketing.AppData
{
    using System;
    using System.Collections.Generic;

    public partial class custInfo
    {
        public custInfo()
        {
           // this.UserInformation = new HashSet<UserInformation>();
        }

        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string userAddress { get; set; }
        public string userEmail { get; set; }
        public string userPhone { get; set; }
        public string custStatus { get; set; }
        public Nullable<int> roleId { get; set; }
        public Nullable<int> createdBy { get; set; }

       // public virtual ICollection<UserInformation> UserInformation { get; set; }
    }
}
