using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class FlightLogic : AirlineLogic
    {
        public List<Flight> GetFlights()
        {
            return r.GetFlights();
        }

        public Flight GetFlightById(int flightId)
        {
            Flight flight = r.GetFlightById(flightId);
            return flight;
        }

        public void Edit(Flight flight)
        {
            r.EditFlight(flight);
        }

        public void Delete(int flightId)
        {
            Flight flight = r.GetFlightById(flightId);
            if (flight!=null)
            {
                r.DeleteFlight(flight);
            }            
        }

        public void Create(Flight flight)
        {
            r.AddFlight(flight);
        }
    }
}
