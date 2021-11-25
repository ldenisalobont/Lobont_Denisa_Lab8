using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lobont_Denisa_Lab8.Data;
using Lobont_Denisa_Lab8.Models;

namespace Lobont_Denisa_Lab8.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Lobont_Denisa_Lab8.Data.Lobont_Denisa_Lab8Context _context;

        public CreateModel(Lobont_Denisa_Lab8.Data.Lobont_Denisa_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PublisherID"] = new SelectList(_context.Publisher, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
