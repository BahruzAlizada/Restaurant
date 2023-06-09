using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        [Required(ErrorMessage ="Title can not be null")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Description can not be null")]
        [MaxLength(85)]
        public string Description { get; set; }
        public bool IsDeactive { get; set; }
    }
}
