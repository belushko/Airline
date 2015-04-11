﻿using DAL.EntityMetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [MetadataType(typeof(ApplicationMetaData))]
    [Table("Application")]
    public class Application
    {
        public int ApplicationId { get; set; }
        public string Text { get; set; }

        public ApplicationStatus Status { get; set; }

        public User Author { get; set; }
        //public User ToWhom { get; set; }
        public Flight Flight { get; set; }

    }
}
