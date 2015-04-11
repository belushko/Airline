using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityMetaData
{

    class EmployeeMetaData
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15)]
        public string LastName { get; set; }

        [Required]
        [Range(18, 99)]
        public int Age { get; set; }

        [Required]
        public EmployeeType Type { get; set; }
    }
}
