using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class AIROVModel
    {
        public int Id { get; set; }
        
        public string Subject { get; set; }
        
        public string LicensePlateNum { get; set; }
        
        public DateTime ThisAnnualInspectionDate { get; set; }
        
        public DateTime NextAnnualInspectionDate { get; set; }
        
        public int Cost { get; set; }
        
        public string Proposer { get; set; }
        
        public string Department { get; set; }
        
        public DateTime ApplicationDate { get; set; }
        
        public string AnnualInspectionSite { get; set; }
        
        public string ContactNumber { get; set; }
        
        public string Operator { get; set; }
        
        public string Remark { get; set; }


    }
}
