﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsDeactive { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
