using Microsoft.EntityFrameworkCore;
using ProjectRouteGym.Models.Plans;

namespace ProjectRouteGym.Data.Seed;

public static class PlanSeeder
{
    public static async Task SeedAsync(ApplicationDbContext dbContext)
    {
        if(await dbContext.Plans.AnyAsync())
        {
            return;
        }
        List<Plan> plans = [
            new Plan
            {
                Name = "Free",
                Price = 0,
                DurationDays = 30,
                Description = "Basic gym access with limited features.",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },

            new Plan
            {
                Name = "Standard",
                Price = 500,
                DurationDays = 30,
                Description = "Standard gym membership with access to equipment and basic training.",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },

            new Plan
            {
                Name = "Premium",
                Price = 900,
                DurationDays = 30,
                Description = "Premium membership with full gym access and personal training support.",
                IsActive = false,
                CreatedAt = DateTime.UtcNow
            }
            ];

        await dbContext.Plans.AddRangeAsync(plans);
        await dbContext.SaveChangesAsync();
      
    }

}
