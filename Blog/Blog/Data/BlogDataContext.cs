using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    // mapeamento de entidades
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        //conexão com o banco
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Blog;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
            //options.LogTo(Console.WriteLine);
        }
    }
}
