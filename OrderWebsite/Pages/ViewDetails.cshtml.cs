using DataAccess.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace OrderWebsite.Pages
{
   public class ViewDetailsModel : PageModel
    {
        private readonly AppleProductManagerContext _context;

        public ViewDetailsModel(AppleProductManagerContext context)
        {
            _context = context;
        }
        public List<Product> Products { get; set; }
        public List<Cart> Carts { get; set; }
        public void OnGet()
        {
            Carts = _context.Carts.ToList();
            Products = _context.Products.ToList();
        }
    }
}
