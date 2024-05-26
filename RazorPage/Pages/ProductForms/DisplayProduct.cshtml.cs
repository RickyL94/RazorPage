using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Models;

namespace RazorPage.Pages.ProductForms
{
    public class DisplayProductModel : PageModel
    {
        
        private readonly ProductContext _context;


        public DisplayProductModel(ProductContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductModel> Products { get; private set; }

        // OnGetAsync Is typically used when needed to await asynchronous operations within the method.
        public async Task OnGetAsync()
        {
            // Fetch product from the database based on productId
            Products = await _context.GetAllProductsAsync();
        }
    }
}
