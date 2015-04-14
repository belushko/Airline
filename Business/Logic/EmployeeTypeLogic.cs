using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EmployeeTypeLogic : AirlineLogic
    {
        public IEnumerable<EmployeeType> GetEmployeeTypes()
        {
            return r.GetEmployeeTypes();
        }

        public EmployeeType GetEmployeeTypeById(int employeeTypeId)
        {
            EmployeeType employeeType = r.GetEmployeeTypeById(employeeTypeId);
            return employeeType;
        }
    }
}
