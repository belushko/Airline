using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DAL.Entity
{
    [MetadataType(typeof(FlightStatusMetaData))]
    [Table("FlightStatus")]
    public class FlightStatus
    {
        public int FlightStatusId { get; set; }
        public string Name { get; set; }
    }
}
