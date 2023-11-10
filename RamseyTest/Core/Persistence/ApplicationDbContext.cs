using Microsoft.EntityFrameworkCore;
using RamseyTest.Core.Entities;

namespace RamseyTest.Core.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<Student> Student { get; set; }


    }
}
