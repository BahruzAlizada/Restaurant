using System.ComponentModel.DataAnnotations;

namespace Restaurant.ViewsModel
{
    public class LoginVM
    {
        [Required(ErrorMessage ="Username can not be null")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password can not be null")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsDeactive { get; set; }
        public bool IsRemember { get; set; }
    }
}
