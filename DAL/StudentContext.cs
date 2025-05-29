using CRUDApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDApplication.DAL
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            
        }

        public DbSet<Student> StudentTable { get; set; }
    }
}
