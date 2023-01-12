using EntityFrameworkSQL.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSQL.DAL
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public AppContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=library;Trusted_Connection=True;Trust Server Certificate=True;");
        }
    }
}