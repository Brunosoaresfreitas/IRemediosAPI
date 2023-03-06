using IRemedios.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IRemedios.Infrastructure.Context
{
    public class IRemediosDbContext : DbContext
    {
        public IRemediosDbContext(DbContextOptions<IRemediosDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medicine> Medicines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
