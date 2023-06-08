using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="FullName can not be null")]
        public string FullName { get; set; }
        public string Role { get; set; }
        [Required(ErrorMessage ="Description can not be null")]
        [MaxLength(110)]
        public string Description { get; set; }
        public bool IsDeactive { get; set; }
    }
}
