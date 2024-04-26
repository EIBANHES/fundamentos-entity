using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    // mapeamento de entidades -> fluent mapping
    public class BlogDataContext : DbContext
    {
        //conexão com o banco
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Blog;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True");
            //options.LogTo(Console.WriteLine);
        }
    }
}
