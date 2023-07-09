using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeBrewToolsWebApp.Models;

namespace HomeBrewToolsWebApp.Data
{
    public class HomeBrewToolsWebAppContext : DbContext
    {
        public HomeBrewToolsWebAppContext (DbContextOptions<HomeBrewToolsWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<HomeBrewToolsWebApp.Models.HomeBrewLog> HomeBrewLog { get; set; } = default!;
    }
}
