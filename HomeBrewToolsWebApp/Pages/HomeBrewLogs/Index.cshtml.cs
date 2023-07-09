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
    public class IndexModel : PageModel
    {
        private readonly HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext _context;

        public IndexModel(HomeBrewToolsWebApp.Data.HomeBrewToolsWebAppContext context)
        {
            _context = context;
        }

        public IList<HomeBrewLog> HomeBrewLog { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.HomeBrewLog != null)
            {
                HomeBrewLog = await _context.HomeBrewLog.ToListAsync();
            }
        }
    }
}
