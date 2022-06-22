using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCartNetCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ShoppingCartContext _context;

        public IndexModel(ILogger<IndexModel> logger, ShoppingCartContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Category)
                .Include(p => p.Mark)
                .Include(p => p.Supplier).ToListAsync();
        }
    }
}