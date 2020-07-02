using Microsoft.AspNetCore.Server.Kestrel.Core.Adapter.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstApproachDemp.Models
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext context;

        public SqlEmployeeRepository(EmployeeDbContext context)
        {
            this.context = context;
        }

        public void AddEmployee(Employee e)
        {
            this.context.Employees.Add(e);
            this.context.SaveChanges();
        }

        public void DeleteEmployee(Employee e)
        {
            this.context.Employees.Remove(e);
            this.context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return this.context.Employees.ToList<Employee>();
        }

        public Employee GetEmployee(int? employeeid)
        {
           Employee e= this.context.Employees.Find(employeeid);
            return e;
        }

        public void UpdateEmployee(Employee e)
        {
            this.context.Employees.Update(e);
            this.context.SaveChanges();
        }
    }
}
