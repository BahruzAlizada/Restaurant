using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Restaurant.Models;

namespace Restaurant.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<Slider> Slider { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Bio> Bio { get; set; }
        public DbSet<Social_Media> SocialMedias { get; set; }
        public DbSet<ContactInfo> ContactnInfo { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Cheff> Chefs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Position>().HasData(
                new Position {Id=1, PositionName = "Chef", Salary = 600 },
                new Position {Id=2, PositionName = "Master Chef", Salary = 1000 },
                new Position {Id=3, PositionName = "Wailter", Salary=400});   
        }

    }
}
