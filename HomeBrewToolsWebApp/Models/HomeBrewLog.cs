using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeBrewToolsWebApp.Models
{
    // The following code adheres to the Single Responsiblity principle of SOLID Programming by only
    // defining the properties of the home brew log

    // The following code also adheres to the Open/Closed principle of SOLID Programming by using the Display
    // attribute allowing the code to be extended without modifying the existing code. This allows me to 
    // change the display without touching the classes code dircetly 
    public class HomeBrewLog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Type { get; set; } = null;

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]

        [Display(Name = "Starting Gravity")]
        public decimal StartingGravity { get; set; }

        [Display(Name = "Updated Gravity")]
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? UpdatedGravity { get; set; }

        [Display(Name = "Final Gravity")]
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? FinalGravity { get; set; }

        [Display(Name = "Updated Date")]
        [DataType(DataType.Date)]
        public DateTime? UpdatedDate { get; set; }
    }
}
