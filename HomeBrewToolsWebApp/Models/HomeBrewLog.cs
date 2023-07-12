using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeBrewToolsWebApp.Models
{
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
