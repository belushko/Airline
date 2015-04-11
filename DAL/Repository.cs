using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository
    {
        AirlineContext db = new AirlineContext();


        /// <summary>
        /// FLIGHT REPOSITORY
        /// </summary>
        /// <returns></returns>
        public List<Flight> GetFlights()
        {
            return db.Flight.ToList();
        }

        public Flight GetFlightById(int flightId)
        {
            return db.Flight.FirstOrDefault(f => f.FlightId == flightId);
        }

        public void EditFlight(Flight flight)
        {
            db.Entry(flight).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void AddFlight(Flight flight)
        {
            db.Flight.Add(flight);
            db.SaveChanges();
        }

        public void DeleteFlight(Flight flight)
        {
            db.Flight.Remove(flight);
            db.SaveChanges();
        }
    }
}
