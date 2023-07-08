using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iShop.Data;
using iShop.Models;

namespace iShop.Pages.Admin.ManageUsers
{
    public class IndexModel : PageModel
    {
        private readonly iShop.Data.iShopContext _context;

        public IndexModel(iShop.Data.iShopContext context)
        {
            _context = context;
        }

        public IList<Users> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
