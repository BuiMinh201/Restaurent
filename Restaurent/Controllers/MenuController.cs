using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCore.Models;
using MyCore.Models.Entity;

namespace Restaurent.Controllers
{
    public class MenuController : Controller
    {
        private readonly RestaurentContext _context;
        public MenuController(RestaurentContext restaurentContext)
        {
            _context = restaurentContext;
        }
        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            var type = _context.ProductType.ToList();
            ViewBag.ProductType = type;
            return View(products);
        }
        public async Task<IActionResult> Search(string searchTerm, string[] searchbox)
        {
            var products = await _context.Product
            .Where(p => p.Name.Contains(searchTerm) || p.Content.Contains(searchTerm)).
            ToListAsync();
            var type = _context.ProductType.ToList();
            ViewBag.Keyword = searchTerm;
            ViewBag.ProductType = type;
            ViewBag.SearchBox = searchbox;
            return View(products);
        }
    }
}
