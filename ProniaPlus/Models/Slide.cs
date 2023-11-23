using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProniaPlus.Models
{
    public class Slide
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        [MaxLength(25, ErrorMessage = "It should not exceed 25 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        [MaxLength(50, ErrorMessage = "It should not exceed 25 characters")]
        public string SubTitle { get; set; }
        [Required(ErrorMessage = "Name must be entered mutled")]
        [MaxLength(100, ErrorMessage = "It should not exceed 25 characters")]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile? Photo { get; set; }
    }
}
