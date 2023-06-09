using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email can not be null")]
        public string BookingEmail { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email can not be null")]
        public string GeneralEmail { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email can not be null")]
        public string TechinialEmail { get; set; }
    }
}
