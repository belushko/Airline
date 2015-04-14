using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DAL.Entity
{
    public class FlightStatusMetaData
    {
        [Key]
        public int FlightStatusId { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }
    }
}
