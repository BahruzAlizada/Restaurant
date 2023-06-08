using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Title can not be null")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Description can not be null")]
        public string Description { get; set; }
        public int Experience { get; set; }
        public int PopularMasterChef { get; set; }
       

    }
}
