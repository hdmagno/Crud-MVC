using Microsoft.EntityFrameworkCore;

namespace CourseMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CourseMVC;Integrated Security=True");
        }
    }
}
