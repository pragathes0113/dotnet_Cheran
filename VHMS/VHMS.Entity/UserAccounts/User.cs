using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHMS.Entity
{
    public class User
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public Employee Employee { get; set; }
        public string RoleName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string OldPassword { get; set; }
        public Boolean IsActive { get; set; }
        public User CreatedBy { get; set; }
        public Machines Machines { get; set; }
        public DateTime CreatedOn { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ConfirmPassword { get; set; }
        public Settings Settings { get; set; }
    }
    public class VisitLog
    {
        public int PageLogID { get; set; }
        public DateTime VisitLogDateTime { get; set; }
        public string sVisitLogDateTime { get; set; }
        public string IPAddress { get; set; }
        public string UserName { get; set; }
        public string URL { get; set; }
    }
}
