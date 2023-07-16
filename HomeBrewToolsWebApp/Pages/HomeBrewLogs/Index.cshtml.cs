using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeBrewToolsWebApp.Data;
using HomeBrewToolsWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Types { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? HomeBrewType { get; set; }

        public async Task OnGetAsync()
        {
            

            var homeBrewLogs = from h in _context.HomeBrewLog
                               select h;

            if (!string.IsNullOrEmpty(SearchString))
            {
                homeBrewLogs = homeBrewLogs.Where(s => s.Name.Contains(SearchString));
            }

            HomeBrewLog = await homeBrewLogs.ToListAsync();


            //if (_context.HomeBrewLog != null)
            //{
            //    HomeBrewLog = await _context.HomeBrewLog.ToListAsync();
            //}
        }
    }
}
