#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesArileKris.Models;
using RazorPagesKrrisArile.Data;


namespace RazorPagesKrrisArile.Pages.Sheets
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext _context;

        public EditModel(RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sheet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SheetExists(Sheet.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SheetExists(int id)
        {
            return _context.Sheet.Any(e => e.ID == id);
        }
    }
}
