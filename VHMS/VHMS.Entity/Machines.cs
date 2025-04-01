using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHMS.Entity
{
    public class Machines
    {
        public int MachinesID { get; set; }
        public string MachinesName { get; set; }
        public string TransportNumber { get; set; }
        public string OwnerMobileNo { get; set; }
        public string ManagerMobileNo { get; set; }
        public string VehicleChassisNo { get; set; }
        public string RCNo { get; set; }
        public string sRCDate { get; set; }
        public string Address { get; set; }
        public DateTime RCDate { get; set; }
        public string InsuranceNo { get; set; }
        public string sInsuranceDate { get; set; }
        public DateTime InsuranceDate { get; set; }
        public string sFCDate { get; set; }
        public DateTime FCDate { get; set; }
        public string sTaxDate { get; set; }
        public DateTime TaxDate { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string FinancialYear { get; set; }
    }

}
