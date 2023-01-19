using EmployeeAPi.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPi.Data
{
    public class EmployeeDbContext: DbContext
    {
        public EmployeeDbContext(DbContextOptions options):base(options)
        {

        }
        //dbsetcreate the columns/table of database 
        public DbSet<Employee> Employees { get; set; }
    }
}
