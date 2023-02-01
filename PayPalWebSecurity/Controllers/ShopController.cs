using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PayPalWebSecurity.Data;
using PayPalWebSecurity.Models;

namespace PayPalWebSecurity.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DbSet<Product> products = _context.Products;
            return View(products);
        }
    }
}
