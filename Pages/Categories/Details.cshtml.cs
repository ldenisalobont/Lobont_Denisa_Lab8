using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lobont_Denisa_Lab8.Data;
using Lobont_Denisa_Lab8.Models;

namespace Lobont_Denisa_Lab8.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Lobont_Denisa_Lab8.Data.Lobont_Denisa_Lab8Context _context;

        public DetailsModel(Lobont_Denisa_Lab8.Data.Lobont_Denisa_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b => b.Publisher).FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
