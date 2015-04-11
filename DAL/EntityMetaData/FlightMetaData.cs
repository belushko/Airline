using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class FlightMetaData
    {
        [Key]
        public int FlightId { get; set; }

        [Required]
        [StringLength(15)]
        public string From { get; set; }

        [Required]
        [StringLength(15)]
        public string To { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DepatureDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }

        [Required]
        public FlightStatus Status { get; set; }
    }
}
