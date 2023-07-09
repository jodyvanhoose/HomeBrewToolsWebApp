using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeBrewToolsWebApp.Data;
using HomeBrewToolsWebApp.Models;

namespace HomeBrewToolsWebApp.Pages.HomeBrewLogs
{
    public class EditModel : PageModel
    {
        private readonly HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext _context;

        public EditModel(HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext context)
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

            var homebrewlog =  await _context.HomeBrewLog.FirstOrDefaultAsync(m => m.Id == id);
            if (homebrewlog == null)
            {
                return NotFound();
            }
            HomeBrewLog = homebrewlog;
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

            _context.Attach(HomeBrewLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomeBrewLogExists(HomeBrewLog.Id))
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

        private bool HomeBrewLogExists(int id)
        {
          return (_context.HomeBrewLog?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
