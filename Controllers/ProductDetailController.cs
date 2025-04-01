using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCore.Models.Entity;
using Restaurent.Models.Entity;
using Restaurent.Models.Entity.ViewModels;

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
            var productsById = _context.Product.Include(p => p.Ratings)
                .Where(p => p.Id == Id).FirstOrDefault();
            ViewBag.ProductTopping = _context.ProductTopping.ToList();
            var viewModel = new ProductDetails
            {
                Products = productsById
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CommentProduct(Ratings rating)
        {
            if (ModelState.IsValid)
            {
                var ratingEntity = new Ratings
                {
                    ProductID = rating.ProductID,
                    Comment = rating.Comment,
                    Rating = rating.Rating,
                    UserID = rating.UserID
                };
                _context.Ratings.Add(ratingEntity);
                await _context.SaveChangesAsync();
                return Redirect(Request.Headers["Referer"]);
            }
            else
            {
                TempData["error"] = "Model có một vài thứ đang lỗi";
                List<string> errors = new List<string>();
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                string errorMessage = string.Join("\n", errors);

                return RedirectToAction("Detail", new { id = rating.ProductID });
            }
                return Redirect(Request.Headers["Referer"]);
        }
    }
}
