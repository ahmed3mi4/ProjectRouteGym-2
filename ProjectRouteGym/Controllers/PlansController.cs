using Microsoft.AspNetCore.Mvc;

using ProjectRouteGym.Business.Repositories;


namespace ProjectRouteGym.Controllers;

public class PlansController(IPlanRepository planRepository) : Controller
{
 
    public async Task<IActionResult> Index()
    {
        var plans = await planRepository.GetAll();
        return View(plans);
    }
    public async Task<IActionResult> Details(int id)
    {
        var plan = await planRepository.GetById(id);
        if (plan == null)
            return RedirectToAction(nameof(Index));
        return View(plan);
    }
}
