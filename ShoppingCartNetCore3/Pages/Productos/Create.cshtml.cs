using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShoppingCartNetCore3.Data;
using ShoppingCartNetCore3.Models;

namespace ShoppingCartNetCore3.Pages.Productos
{
    public class CreateModel : PageModel
    {
        private readonly ShoppingCartNetCore3.Data.ShoppingCartContext _context;

        public CreateModel(ShoppingCartNetCore3.Data.ShoppingCartContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name");
        ViewData["MarkId"] = new SelectList(_context.Mark, "Id", "Name");
        ViewData["SupplierId"] = new SelectList(_context.Supplier, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
