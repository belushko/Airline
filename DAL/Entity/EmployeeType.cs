using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace DAL.Entity
{
    [MetadataType(typeof(EmployeeTypeMetaData))]
    [Table("EmployeeType")]
    public class EmployeeType
    {
        public int EmployeeTypeId { get; set; }
        public string Name { get; set; }
    }
}
