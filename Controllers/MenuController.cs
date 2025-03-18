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

        public async Task<IActionResult> Search(string searchTerm, List<string> categories)
        {
            var products = _context.Product
                .Include(p => p.ProductType) 
                .AsQueryable();

            
            if (!string.IsNullOrEmpty(searchTerm))
            {
                products = products.Where(p => p.Name.Contains(searchTerm) || p.Content.Contains(searchTerm));
            }

            
            if (categories != null && categories.Any())
            {
                products = products.Where(p => categories.Contains(p.ProductType.Name));
            }

            var result = await products.ToListAsync();

            ViewBag.Keyword = searchTerm;
            ViewBag.ProductType = _context.ProductType.ToList();
            ViewBag.SelectedCategories = categories ?? new List<string>();

            return View(result);
        }
    }
}
