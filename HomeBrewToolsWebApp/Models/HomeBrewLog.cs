using System.ComponentModel.DataAnnotations;

namespace HomeBrewToolsWebApp.Models
{
    public class HomeBrewLog
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Type { get; set; } = null;

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal StartingGravity { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? UpdatedGravity { get; set; }
        [DisplayFormat(DataFormatString = "{0:F3}")]
        public decimal? FinalGravity { get; set; }

        [DataType(DataType.Date)]
        public DateTime? UpdatedDate { get; set; }
    }
}
