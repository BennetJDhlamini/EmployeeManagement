using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public IWebHostEnvironment hostingEnvironment;

        public MockEmployeeRepository(IWebHostEnvironment hostingEnvironment)
        {
            _employeeList = new List<Employee>()
        {
            new Employee() { Id = 1, Name = "Bennet", Role = "Software Developer" },
            new Employee() { Id = 2, Name = "Mike", Role = "HR" },
            new Employee() { Id = 3, Name = "Sam", Role = "Database Developer"},
        };
            this.hostingEnvironment = hostingEnvironment;
        }
        public Employee GetEmployee(int id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == id);
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee photo = _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if (photo != null)
            {
                photo.Name = employeeChanges.Name;
                photo.Role = employeeChanges.Role;
            }
            return photo;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> Search(string searchEmployee = null)
        {
            if (string.IsNullOrEmpty(searchEmployee))
            {
                return _employeeList;
            }

            return _employeeList.Where(e => e.Name.Contains(searchEmployee) ||
                                            e.Email.Contains(searchEmployee)).ToList();
        }
    }
}