using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class VARModel
    {
        public int Id { get; set; }
        
        public string Subject { get; set; }
        
        public string LicensePlateNum { get; set; }
        
        public string Driver { get; set; }
        
        public DateTime Time { get; set; }
        
        public string Place { get; set; }
        
        public string ConcreteContent { get; set; }
        
        public string Duty { get; set; }
        
        public string MaintenanceFactory { get; set; }
        
        public DateTime MaintenanceDate { get; set; }
        
        public DateTime MaintenanceEndDate { get; set; }
        
        public int LossExpense { get; set; }
        
        public int InsuranceClaimAmount { get; set; }
        
        public int DriverCompensationAmount { get; set; }
        
        public int MaintenanceCost { get; set; }
        
        public string MaintenanceContent { get; set; }


    }
}
