using DataAccess.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace OrderWebsite.Pages
{
    public class SearchModel : PageModel
    {
        private readonly AppleProductManagerContext _context;

        public SearchModel(AppleProductManagerContext context)
        {
            _context = context;
        }
        public List<ProductType> Category { get; set; }
        public List<Product> Products { get; set; }
        public List<Cart> Carts { get; set; }
        public void OnGet()
        {
            Carts = _context.Carts.ToList();
            Products = _context.Products.ToList();      
            Category = _context.ProductTypes.ToList();
        }
    }
}
