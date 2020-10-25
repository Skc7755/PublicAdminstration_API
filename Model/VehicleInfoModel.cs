using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class VehicleInfoModel
    {
        public int Id { get; set; }        
       
        public string CarName { get; set; }

        public string LicensePlateNum { get; set; }
        
        public string Specifications { get; set; }
        
        public string FuelConsumption { get; set; }
        
        public string UnitPrice { get; set; }
        
        public string Color { get; set; }
        
        public string Producers { get; set; }
        
        public DateTime ProductionDate { get; set; }
        
        public string Supplier { get; set; }
        
        public DateTime PurchaseDate { get; set; }
        
        public string EnginNum { get; set; }
        
        public string VIN { get; set; }
        
        public string DepositRegion { get; set; }
        
        public string Custodian { get; set; }
        
        public DateTime NextInspection { get; set; }
        
        public DateTime InsuranceExpirationDate { get; set; }
        
        public DateTime LastMaintenanceDate { get; set; }
        
        public string AutoState { get; set; }
    }
}
