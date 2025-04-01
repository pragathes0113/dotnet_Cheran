using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHMS.Entity
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string PhoneNo1 { get; set; }
        public string PhoneNo2 { get; set; }
        public DateTime Dateofjoin { get; set; }
        public string sDateofjoin { get; set; }
        public string IDProof { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public decimal BasicPay { get; set; }
        public Boolean IsActive { get; set; }
        public User CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public User ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
          

        
    }
}