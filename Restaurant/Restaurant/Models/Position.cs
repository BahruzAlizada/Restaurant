using System.Collections.Generic;

namespace Restaurant.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int Salary { get; set; }
        public List<Employee>  Employees { get; set; }
    }
}
