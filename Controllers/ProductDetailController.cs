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
        public async Task<IActionResult> Detail(long Id)
        {
            if (Id == null) return RedirectToAction("Index");
            var productsById = _context.Product.Where(p => p.Id == Id).FirstOrDefault();
            return View(productsById);
        }
    }
}
