using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class VMRModel
    {
        public int Id { get; set; }
       
        public string Subject { get; set; }
        
        public string LicensePlateNum { get; set; }
        
        public string Type { get; set; }
        
        public string TimeQuantum { get; set; }
        
        public int Cost { get; set; }
        
        public string Proposer { get; set; }
        
        public string Department { get; set; }
        
        public DateTime ApplicationDate { get; set; }
        
        public string MaintenanceCompany { get; set; }
        
        public string Operator { get; set; }
        
        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }
        
        public string ConcreteContent { get; set; }
        
        public string Remark { get; set; }
    }
}
