using Microsoft.EntityFrameworkCore;
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
    }
}
