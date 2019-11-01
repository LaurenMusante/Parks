using System.ComponentModel.DataAnnotations;

namespace Parks.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        [Required]
        [StringLength (8)]
        public string StateOrNational { get; set; }
        [Required]
        [StringLength(2)]
        public string State { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Rating must land between 1 and 10")]
        public int Rating { get; set; }
    }
}