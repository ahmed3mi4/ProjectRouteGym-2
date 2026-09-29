using ProjectRouteGym.Business.Entities.Plans;

namespace ProjectRouteGym.Business.Repositories;

public interface IPlanRepository
{
    Task <IEnumerable<Plan>> GetAll();
    Task<Plan?> GetById(int id);

    void Add(Plan plan);
    void Update(Plan plan);

    void Delete(Plan plan);

    Task<int> SaveChanges();


}
