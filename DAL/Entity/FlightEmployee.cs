﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [MetadataType(typeof(FlightEmployeeMetaData))]
    [Table("FlightEmployee")]
    public class FlightEmployee
    {
        public Flight Flight { get; set; }
        public Employee Employee { get; set; }
    }
}
