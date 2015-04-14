using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class UserMetaData
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string Login { get; set; }

        [Required]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15)]
        public string LastName { get; set; }
    }
}
