using Blog.Data;
using Blog.Models;

class Program
{
    static void Main(string[] args)
    {
        using var context = new BlogDataContext();
        //context.Users.Add(new User
        //{
        //    Name = "André Baltieri",
        //    Slug = "andrebaltieri",
        //    Email = "andre@balta.io",
        //    Bio = "9x Microsoft MVP",
        //    Image = "https://balta.io",
        //    PasswordHash = "123098457"
        //});
        //context.SaveChanges();

        var user = context.Users.FirstOrDefault();
        var post = new Post {
            Author = user,
            Body = "Teste",
            Category = new Category { Name = "Backend", Slug = "backend" },
            CreateDate = DateTime.Now,
            //LastUpdateDate = DateTime.Now,
            Slug = "meu-artigo",
            Summary = "teste fluent mapping",
            Title = "Title"
        };
        context.Posts.Add(post);
        context.SaveChanges();
    }
}