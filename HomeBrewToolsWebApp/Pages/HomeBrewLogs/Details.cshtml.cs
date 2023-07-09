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
    public class DetailsModel : PageModel
    {
        private readonly HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext _context;

        public DetailsModel(HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext context)
        {
            _context = context;
        }

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
    }
}
