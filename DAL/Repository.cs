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


        /// <summary>
        /// FlightStatus REPOSITORY
        /// </summary>
        /// <returns></returns>
        /// 

        public List<FlightStatus> GetFlightStatuses()
        {
            return db.FlightStatus.ToList();
        }

        public FlightStatus GetFlightStatusById(int flightStatusId)
        {
            return db.FlightStatus.FirstOrDefault(f => f.FlightStatusId == flightStatusId);
        }

        public void EditFlightStatus(FlightStatus flightStatus)
        {
            db.Entry(flightStatus).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void AddFlightStatus(FlightStatus flightStatus)
        {
            db.FlightStatus.Add(flightStatus);
            db.SaveChanges();
        }

        public void DeleteFlightStatus(FlightStatus flightStatus)
        {
            db.FlightStatus.Remove(flightStatus);
            db.SaveChanges();
        }


        /// <summary>
        /// Employee REPOSITORY
        /// </summary>
        /// <returns></returns>
        /// 

        public List<Employee> GetEmployees()
        {
            return db.Employee.ToList();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return db.Employee.FirstOrDefault(e => e.EmployeeId == employeeId);
        }

        public void EditEmployee(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void AddEmployee(Employee employee)
        {
            db.Employee.Add(employee);
            db.SaveChanges();
        }

        public void DeleteEmployee(Employee employee)
        {
            db.Employee.Remove(employee);
            db.SaveChanges();
        }

        /// <summary>
        /// EmployeeType REPOSITORY
        /// </summary>
        /// <returns></returns>
        /// 

        public List<EmployeeType> GetEmployeeTypes()
        {
            return db.EmployeeType.ToList();
        }

        public EmployeeType GetEmployeeTypeById(int employeeTypeId)
        {
            return db.EmployeeType.FirstOrDefault(e => e.EmployeeTypeId == employeeTypeId);
        }
    }
}
