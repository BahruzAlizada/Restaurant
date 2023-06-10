﻿namespace Restaurant.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public Position Position { get; set; }
        public int PositionId { get; set; }
    }
}
