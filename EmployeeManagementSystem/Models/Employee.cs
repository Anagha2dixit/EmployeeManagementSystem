using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Role { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
