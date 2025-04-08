using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHMS.Entity
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string AgentName { get; set; }
        public string RateName { get; set; }
        public string MobileNo { get; set; }
        public string AlternateNo { get; set; }
        public string WhatsappNo { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }


}