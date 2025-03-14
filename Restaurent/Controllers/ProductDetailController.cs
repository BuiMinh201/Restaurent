using Microsoft.AspNetCore.Mvc;
using MyCore.Models.Entity;

namespace Restaurent.Controllers
{
    public class ProductDetailController : Controller
    {
        private readonly RestaurentContext _context;
        public ProductDetailController(RestaurentContext restaurentContext)
        {
            _context = restaurentContext;
        }
        public IActionResult Index()
        {
            var products = _context.Product.ToList();
            return View(products);
        }
    }
}
