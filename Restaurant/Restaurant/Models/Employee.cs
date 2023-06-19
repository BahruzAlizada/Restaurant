using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
    }
}
