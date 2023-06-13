using Restaurant.Models;
using System.Collections.Generic;

namespace Restaurant.ViewsModel
{
    public class ContactVM
    {
        public List<ContactInfo> ContactInfo { get; set; }
        public List<ContactForm> Form { get; set; }
    }
}
