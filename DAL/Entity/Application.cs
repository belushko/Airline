using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public string Text { get; set; }

        public ApplicationStatus Status { get; set; }

        public User Author { get; set; }
        public User ToWhom { get; set; }
        public Flight Flight { get; set; }

    }
}
