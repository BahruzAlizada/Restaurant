using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Icons { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
