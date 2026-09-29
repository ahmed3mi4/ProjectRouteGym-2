using Microsoft.EntityFrameworkCore;
using ProjectRouteGym.Business.Entities.Plans;

namespace ProjectRouteGym.DataAccess.Data;



public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Plan> Plans { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
