using FrontToBack_Karma.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack_Karma.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Football> Footballs { get; set; }
    }
}
