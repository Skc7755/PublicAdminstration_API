using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class APAModel
    {
        public int Id { get; set; }
        
        public string Subject { get; set; }
        
        public string  Proposer { get; set; }
        
        public string  Department { get; set; }
        
        public DateTime ApplicationDate { get; set; }
        
        public int Amount { get; set; }
        
        public string  AssetName { get; set; }
        
        public string  Specification { get; set; }
        
        public int EstimatedPrice { get; set; }
        
        public string  Purpose { get; set; }
        
        public string  Remark { get; set; }
    
    }
}
