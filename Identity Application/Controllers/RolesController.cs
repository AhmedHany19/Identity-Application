using Identity_Application.ViewRole;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Identity_Application.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RolesController : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task< IActionResult> Index()
        {
            return View(await _roleManager.Roles.ToListAsync());
        }

        public async Task<IActionResult> Add(RoleFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", await _roleManager.Roles.ToListAsync());
            }
            
            if (await _roleManager.RoleExistsAsync(model.Name))
            {
                ModelState.AddModelError("Name", "Role Is Exists!!!");
                return View("Index",await _roleManager.Roles.ToListAsync());
            }

            await _roleManager.CreateAsync(new IdentityRole(model.Name.Trim()));

            return RedirectToAction(nameof(Index));
        }

    }
}
