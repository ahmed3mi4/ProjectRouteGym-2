using Microsoft.EntityFrameworkCore;
using ProjectRouteGym.Business.Entities.Plans;
using ProjectRouteGym.Business.Repositories;
using ProjectRouteGym.DataAccess.Data;


namespace ProjectRouteGym.DataAccess.Repositories;

public class PlanReprository : IPlanRepository
{
    private readonly ApplicationDbContext _db;
    public PlanReprository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Plan>> GetAll()
    
        =>await _db.Plans.ToListAsync();

    public async Task<Plan?> GetById(int id)

    => await _db.Plans.FirstOrDefaultAsync();
    public void Add(Plan plan)

    => _db.Plans.Add(plan);

    public void Update(Plan plan)

    => _db.Plans.Update(plan);
    public void Delete(Plan plan)

    => _db.Plans.Remove(plan);

    public async Task<int> SaveChanges()
    => await _db.SaveChangesAsync();
}
