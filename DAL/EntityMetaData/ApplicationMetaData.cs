using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityMetaData
{
    public class ApplicationMetaData
    {
        [Key]
        public int ApplicationId { get; set; }

        [Required]
        [StringLength(200)]
        public string Text { get; set; }

        [Required]
        public ApplicationStatus Status { get; set; }

        [Required]
        public User Author { get; set; }

        //[Required]
        //public User ToWhom { get; set; }

        [Required]
        public Flight Flight { get; set; }
    }
}
