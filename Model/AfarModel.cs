using System;

namespace Model
{
    public class AfarModel
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Proposer { get; set; }

        public string Department { get; set; }

        public DateTime ApplicationDate { get; set; }
        public int Amount { get; set; }

        public string AssetName { get; set; }
        
        public string AssetType { get; set; }
        
        public string Specification { get; set; }
        
        public string SerialNumber { get; set; }
        
        public string ReturnPeople { get; set; }
        
        public string Remark { get; set; }

    }
}
