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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext _context;

        public DetailsModel(RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext context)
        {
            _context = context;
        }

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
    }
}
