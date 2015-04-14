using DAL;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EmployeeLogic : AirlineLogic
    {
        public List<Employee> GetEmployees()
        {
            return r.GetEmployees();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            Employee employee = r.GetEmployeeById(employeeId);
            return employee;
        }

        public void Edit(Employee employee)
        {
            r.EditEmployee(employee);
        }

        public void Delete(int employeeId)
        {
            Employee employee = r.GetEmployeeById(employeeId);
            if (employee != null)
            {
                r.DeleteEmployee(employee);
            }
        }

        public void Create(Employee employee)
        {
            r.AddEmployee(employee);
        }
    }
}
