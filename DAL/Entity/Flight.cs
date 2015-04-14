using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [MetadataType(typeof(FlightMetaData))]
    [Table("Flight")]
    public class Flight
    {
        public int FlightId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Name { get; set; }
        public DateTime DepatureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public virtual FlightStatus Status { get; set; }
    }
}
