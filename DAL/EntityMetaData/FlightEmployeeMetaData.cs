﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class FlightEmployeeMetaData
    {
        [Required]
        public Flight Flight { get; set; }

        [Required]
        public Employee Employee { get; set; }
    }
}
