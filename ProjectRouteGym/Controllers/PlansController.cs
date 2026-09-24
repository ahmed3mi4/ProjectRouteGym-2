using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectRouteGym.Data;

namespace ProjectRouteGym.Controllers;

public class PlansController(ApplicationDbContext dbContext) : Controller
{
 
    public async Task<IActionResult> Index()
    {
        var plans = await dbContext.Plans.ToListAsync();
        return View(plans);
    }
    public async Task<IActionResult> Details(int id)
    {
        var plan = await dbContext.Plans.FirstOrDefaultAsync(p => p.Id == id);
        if (plan == null)
            return RedirectToAction(nameof(Index));
        return View(plan);
    }
}
