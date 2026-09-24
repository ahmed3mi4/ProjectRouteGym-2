namespace ProjectRouteGym.Data.Seed;

public static class DataBaseSeeder
{
    public static async Task SeedAsync(ApplicationDbContext dbContext)
    {
        await PlanSeeder.SeedAsync(dbContext);
    }
}
