using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeBrewToolsWebApp.Data;
using HomeBrewToolsWebApp.Models;

namespace HomeBrewToolsWebApp.Pages.HomeBrewLogs
{
    public class DeleteModel : PageModel
    {
        private readonly HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext _context;

        public DeleteModel(HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext context)
        {
            _context = context;
        }

        [BindProperty]
      public HomeBrewLog HomeBrewLog { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.HomeBrewLog == null)
            {
                return NotFound();
            }

            var homebrewlog = await _context.HomeBrewLog.FirstOrDefaultAsync(m => m.Id == id);

            if (homebrewlog == null)
            {
                return NotFound();
            }
            else 
            {
                HomeBrewLog = homebrewlog;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.HomeBrewLog == null)
            {
                return NotFound();
            }
            var homebrewlog = await _context.HomeBrewLog.FindAsync(id);

            if (homebrewlog != null)
            {
                HomeBrewLog = homebrewlog;
                _context.HomeBrewLog.Remove(HomeBrewLog);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
