using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using DAL.EntityMetaData;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [MetadataType(typeof(ApplicationStatusMetaData))]
    [Table("ApplicationStatus")]
    public class ApplicationStatus
    {
        public int ApplicationStatusId { get; set; }
        public string Name { get; set; }
    }
}
