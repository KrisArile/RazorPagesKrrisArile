#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesArileKris.Models;
using RazorPagesKrrisArile.Data;

namespace RazorPagesKrrisArile.Pages.Sheets
{
#pragma disable CS8618
#pragma disable CS8601
#pragma disable CS8602
#pragma disable CS8604
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext _context;

        public DeleteModel(RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sheet Sheet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sheet = await _context.Sheet.FirstOrDefaultAsync(m => m.ID == id);

            if (Sheet == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Sheet = await _context.Sheet.FindAsync(id);

            if (Sheet != null)
            {
                _context.Sheet.Remove(Sheet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
#pragma restore CS8618
#pragma restore CS8601
#pragma restore CS8602
#pragma restore CS8604
}
