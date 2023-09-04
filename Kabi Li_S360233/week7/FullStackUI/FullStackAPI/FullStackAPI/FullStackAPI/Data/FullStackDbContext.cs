using FullStackAPI.models;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Data
{
    public class FullstackDbcontext : DbContext
    {
        public FullstackDbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
