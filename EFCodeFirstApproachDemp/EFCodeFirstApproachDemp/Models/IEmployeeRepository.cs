using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstApproachDemp.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int? employeeid);
        List<Employee> GetAllEmployees();

        void AddEmployee(Employee e);

        void UpdateEmployee(Employee e);

        void DeleteEmployee(Employee e);
    }
}
