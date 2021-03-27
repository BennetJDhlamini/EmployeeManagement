using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Bennet",
                    Gender = Gen.Male,
                    Role = "Software Developer",
                    Email = "bennet@employeemanagement.com",
                    Contact = "0165986524",
                    Office = "3-B4"
                }
                
            ); ;
        }
    }
}
