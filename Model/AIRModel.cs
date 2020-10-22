using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AIRModel
    {
        public int Id { get; set; }
       
        public string Subject { get; set; }
        
        public string CarName { get; set; }
        
        public string DurationOfInsurance { get; set; } 
        
        public int TotalCostOfInsurance { get; set; }
        
        public string InsuranceCompany { get; set; }
        
        public string Proposer { get; set; }
        
        public string Department { get; set; }
        
        public DateTime ApplicationDate { get; set; }
        
        public string LicensePlateNum { get; set; }
        
        public string InsuranceCompanyTel { get; set; }
        
        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }
        
        public string Operator { get; set; }

    }
}
