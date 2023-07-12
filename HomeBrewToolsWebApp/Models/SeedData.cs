using Microsoft.EntityFrameworkCore;
using HomeBrewToolsWebApp.Data;

namespace HomeBrewToolsWebApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HomeBrewToolsWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HomeBrewToolsWebAppContext>>()))
            {
                if (context == null || context.HomeBrewLog == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.HomeBrewLog.Any())
                {
                    return;   // DB has been seeded
                }

                context.HomeBrewLog.AddRange(
                    new HomeBrewLog
                    {
                        Name = "Snausberry",
                        Type = "IPA",
                        StartDate = DateTime.Parse("2023-6-13"),
                        StartingGravity = 1.060M,
                        UpdatedGravity = 1.018M,
                        FinalGravity = 1.010M,
                        UpdatedDate = DateTime.Parse("2023-7-09")
                    },

                    new HomeBrewLog
                    {
                        Name = "Viking Blod",
                        Type = "Mead",
                        StartDate = DateTime.Parse("2023-5-15"),
                        StartingGravity = 1.1010M,
                        UpdatedGravity = 1.020M,
                        UpdatedDate = DateTime.Parse("2023-6-10")
                    },

                    new HomeBrewLog
                    {
                        Name = "Sierra Nevada Clone",
                        Type = "Pale Ale",
                        StartDate = DateTime.Parse("2023-7-10"),
                        StartingGravity = 1.054M
                    }
                 
                );
                context.SaveChanges();
            }
        }
    }
}
