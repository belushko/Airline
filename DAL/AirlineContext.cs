using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AirlineContext : DbContext
    {
        //public AirlineContext()
        //    : base("AirlineContext")
        //{

        //}

        public DbSet<Flight> Flight { get; set; }
        public DbSet<Application> Application { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatus { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeType> EmployeeType { get; set; }
        public DbSet<FlightStatus> FlightStatus { get; set; }
        public DbSet<User> User { get; set; }

        //public DbSet<FlightEmployee> FlightEmployee { get; set; }
    }
}
