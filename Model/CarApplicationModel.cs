using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
   public class CarApplicationModel
    {
        public int Id { get; set; }

        public string Subject { get; set; }

        public string Proposer { get; set; }

        public string Department { get; set; }

        public string VehicleName { get; set; }

        public string TimeQuantum { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string Driver { get; set; }

        public string Passenger { get; set; }

        public int PassengerNum { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Reasons { get; set; }

        public string Remark { get; set; }

        public string DriverInfo { get; set; }

        public string TimeAndPlace { get; set; }

        public string ActualCarUseInfo { get; set; }

        public string OilConsumption { get; set; }

        public string UseCost { get; set; }


    }
}
