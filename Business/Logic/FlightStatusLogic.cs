using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class FlightStatusLogic : AirlineLogic
    {
        public IEnumerable<FlightStatus> GetFlightStatuses()
        {
            return r.GetFlightStatuses();
        }

        public FlightStatus GetFlightStatusById(int flightId)
        {
            FlightStatus flight = r.GetFlightStatusById(flightId);
            return flight;
        }

        public void Edit(Flight flight)
        {
            r.EditFlight(flight);
        }

        public void Delete(int flightId)
        {
            Flight flight = r.GetFlightById(flightId);
            if (flight != null)
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
