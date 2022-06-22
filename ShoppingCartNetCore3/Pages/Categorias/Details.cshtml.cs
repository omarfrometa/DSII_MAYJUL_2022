using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ShoppingCartNetCore3.Data;
using ShoppingCartNetCore3.Models;

namespace ShoppingCartNetCore3.Pages.Categorias
{
    public class DetailsModel : PageModel
    {
        private readonly ShoppingCartNetCore3.Data.ShoppingCartContext _context;

        public DetailsModel(ShoppingCartNetCore3.Data.ShoppingCartContext context)
        {
            _context = context;
        }

        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.Id == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
