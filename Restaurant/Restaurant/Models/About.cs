using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public string AboutImage3 { get; set; }
        public string AboutImage4 { get; set; }
        [NotMapped]
        public IFormFile AboutPhoto1 { get; set; }
        [NotMapped]
        public IFormFile AboutPhoto2 { get; set; }
        [NotMapped]
        public IFormFile AboutPhoto3 { get; set; }
        [NotMapped]
        public IFormFile AboutPhoto4 { get; set; }


    }
}
