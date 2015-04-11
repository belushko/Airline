using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Airline.Models
{
    public class FlightView
    {
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
        public string StatusId { get; set; }

        //
        public List<SelectListItem> StatusList { get; set; }
    }
}