using MyCore.Models.Entity;

namespace Restaurent.Models.Entity.ViewModels
{
    public class ProductDetails
    {
        public Product Products { get; set; }
        public string? Comment { get; set; }
        public long? UserID { get; set; }
        public int? Rating { get; set; }
    }
}
