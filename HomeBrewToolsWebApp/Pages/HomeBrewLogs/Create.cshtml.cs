using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using HomeBrewToolsWebApp.Data;
using HomeBrewToolsWebApp.Models;

namespace HomeBrewToolsWebApp.Pages.HomeBrewLogs
{
    public class CreateModel : PageModel
    {
        private readonly HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext _context;

        public CreateModel(HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HomeBrewLog HomeBrewLog { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.HomeBrewLog == null || HomeBrewLog == null)
            {
                return Page();
            }

            _context.HomeBrewLog.Add(HomeBrewLog);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
