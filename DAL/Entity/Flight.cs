using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string  From { get; set; }
        public string To { get; set; }
        public string Name { get; set; }
        public DateTime DepatureDate { get; set; }
        public DateTime ArrivalDate { get; set; }

        //
        public FlightStatus Status { get; set; }
    }
}
