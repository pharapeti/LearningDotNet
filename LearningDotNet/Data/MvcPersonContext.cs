using Microsoft.EntityFrameworkCore;
using LearningDotNet.Models;

namespace LearningDotNet.Data
{
    public class MvcPersonContext : DbContext
    {
        public MvcPersonContext(DbContextOptions<MvcPersonContext> options) : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
