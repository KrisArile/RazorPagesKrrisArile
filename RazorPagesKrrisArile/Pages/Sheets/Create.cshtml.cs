#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesArileKris.Models;
using RazorPagesKrrisArile.Data;

namespace RazorPagesKrrisArile.Pages.Sheets
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class CreateModel : PageModel
    {
        private readonly RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext _context;

        public CreateModel(RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sheet Sheet { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sheet.Add(Sheet);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
