using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iShop.Data;
using iShop.Models;

namespace iShop.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private iShopContext _context;

        public IndexModel(iShopContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Products;
        }

        public void OnPost()
        {

        }
    }
}