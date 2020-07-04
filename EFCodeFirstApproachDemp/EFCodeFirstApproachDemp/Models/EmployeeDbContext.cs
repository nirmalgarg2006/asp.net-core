using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirstApproachDemp.Models
{
    public class EmployeeDbContext : IdentityDbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { EmployeeID = 1, EmployeeName ="Nirmal Garg", 
                    Location="Pune", CompanyName = "Atos Syntel", Department="IT", Designation="Consultant", Salary=5000 },
                new Employee()
                {
                    EmployeeID = 2,
                    EmployeeName = "Neha Goyal",
                    Location = "Pune",
                    CompanyName = "CTS",
                    Department = "IT",
                    Designation = "Consultant",
                    Salary = 10000
                });
        }
    }
}
