using IdentityRoles.Repositories;
using Microsoft.AspNetCore.Mvc;
using PayPalWebSecurity.Data;
using PayPalWebSecurity.ViewModels;

namespace PayPalWebSecurity.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext _context;

        public RoleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Role
        public ActionResult Index()
        {
            RoleRepo roleRepo = new RoleRepo(_context);
            return View(roleRepo.GetAllRoles());
        }

        //GET:Create Role
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //POST : Create Role
        [HttpPost]
        public IActionResult Create([Bind("Id,RoleName")] RoleVM role)
        {

            RoleRepo roleRepo = new RoleRepo(_context);
            bool created = roleRepo.CreateRole(role.RoleName);


            if (created == true)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }

    }
}

