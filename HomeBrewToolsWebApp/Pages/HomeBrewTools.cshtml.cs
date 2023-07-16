using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeBrewToolsWebApp.Pages
{
    public class HomeBrewToolsModel : PageModel
    {

        public double CalculateABV(double og, double fg)
        {
            // Calculates the ABV from the original gravity and final gravity
            double ABV = ABV = (og - fg) * 131.25;
            return ABV;
        }


        public void OnGet()
        {
        }
    }
}
