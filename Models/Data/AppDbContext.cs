using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystemNew.Models;

namespace EmployeeManagementSystemNew.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
