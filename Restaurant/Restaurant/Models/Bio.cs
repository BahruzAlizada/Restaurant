using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Header can not be null")]
        public string Header { get; set; }
        [Required(ErrorMessage ="Footer Address can not be null")]
        public string FooterAddress { get; set; }
        [Required(ErrorMessage ="Footer Phone can not be null")]
        public string FooterPhone { get; set; }
        [Required(ErrorMessage ="Footer Email can not be null")]
        public string FooterEmail { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
    }
}
