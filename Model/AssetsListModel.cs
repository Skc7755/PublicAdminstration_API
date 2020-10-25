using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class AssetsListModel
    {
        public int Id { get; set; }
       
        public string AssetName { get; set; }
        
        public string AssetType { get; set; }
        
        public string Specification { get; set; }
        
        public string SerialNumber { get; set; }
        
        public string Department { get; set; }
        
        public int UnitPrice { get; set; }
        
        public string Manufacturer { get; set; }
        
        public DateTime ProductionDate { get; set; }
        
        public string Supplier { get; set; }
        
        public DateTime PurchaseDate { get; set; }
        
        public string DepositRegion { get; set; }
        
        public int WarrantyPeriod { get; set; }
        
        public string Custodian { get; set; }
        
        public string AssetState { get; set; }
        
        public string Describe { get; set; }
    }
}
