using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name can not be null")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email can not be null")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage ="Date can not be null")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage ="Time can not be null")]
        public DateTime Time { get; set; }
        public string Message { get; set; }
        public DateTime CreatedTime { get; set; }=DateTime.UtcNow.AddHours(4);

    }
}
