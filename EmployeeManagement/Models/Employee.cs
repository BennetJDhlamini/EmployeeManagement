using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required, MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        public Gen? Gender { get; set; }
        [Required]
        public string Role { get; set; }
        [Display(Name = "Office Email")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[employeemanagement]+\.[a-zA-Z0-9-.]+$",ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Office Phone")]
        [RegularExpression(@"^(\+27|0)[1-9][0-9]{8}$", ErrorMessage = "Invalid contact phone format")]
        [MaxLength(10)]
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Office { get; set; }
        public string ImagePath { get; set; }
    }
}
