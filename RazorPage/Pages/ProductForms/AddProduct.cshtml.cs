using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RazorPage.Pages.ProductForms
{
    public class AddProductModel : PageModel
    {
        private readonly ProductContext _context;

        public AddProductModel(ProductContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductModel Product { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Add product using Dapper
            await _context.AddProductAsync(Product);

            return RedirectToPage("/Index");
        }
    }
}
