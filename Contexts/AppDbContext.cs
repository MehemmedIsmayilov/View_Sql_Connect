using Connect_Data_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Connect_Data_Task.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<ContactAbout> contactAbouts { get; set; }
    }
}
