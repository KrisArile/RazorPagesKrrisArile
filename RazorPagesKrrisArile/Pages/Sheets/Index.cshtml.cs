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
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPagesKrrisArile.Pages.Sheets
{
#pragma disable CS8618
#pragma disable CS8604
    public class IndexModel : PageModel
    {
        private readonly RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext _context;

        public IndexModel(RazorPagesKrrisArile.Data.RazorPagesKrrisArileContext context)
        {
            _context = context;
        }

        public IList<Sheet> Sheet { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Name { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SheetName { get; set; }
        public async Task OnGetAsync()
        {
            Sheet = await _context.Sheet.ToListAsync();
        }
    }
#pragma restore CS8618
#pragma restore CS8604
}
