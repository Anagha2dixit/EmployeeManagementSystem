using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystemNew.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Role { get; set; }

        public string Department { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
