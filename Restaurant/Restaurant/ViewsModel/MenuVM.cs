using Restaurant.Models;
using System.Collections.Generic;

namespace Restaurant.ViewsModel
{
    public class MenuVM
    {
        public List<Category> Category { get; set; }
        public List<Product> Products { get; set; }
    }
}
