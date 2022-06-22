using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShoppingCartNetCore3.Data;
using ShoppingCartNetCore3.Models;

namespace ShoppingCartNetCore3.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly ShoppingCartNetCore3.Data.ShoppingCartContext _context;

        public IndexModel(ShoppingCartNetCore3.Data.ShoppingCartContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Mark)
                .Include(p => p.Supplier).ToListAsync();
        }
    }
}
