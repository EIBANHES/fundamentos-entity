using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using var context = new BlogDataContext();

        //var user = new User
        //{
        //    Name = "André Baltieri",
        //    Slug = "andrebaltieri",
        //    Email = "andre@balta.io",
        //    Bio = "9x Microsoft MVP",
        //    Image = "https://balta.io",
        //    PasswordHash = "1234567"
        //};

        //var category = new Category
        //{
        //    Name = "Backend",
        //    Slug = "backend"
        //};

        ////Scope_identity
        //var post = new Post
        //{
        //    Author = user,
        //    Category = category,
        //    Body = "<p>Olá mundo</p>",
        //    Slug = "comecando-com-ef-core",
        //    Summary = "Neste artigo vamos aprender EF Core",
        //    Title = "Começando com EF core",
        //    CreateDate = DateTime.Now,
        //    LastUpdateDate = DateTime.Now,
        //};

        //context.Posts.Add(post);
        //context.SaveChanges();

        //var posts = context
        //    .Posts
        //    .AsNoTracking()
        //    .Include(x => x.Author) // Inclui o author na query, inner join
        //    .Include(x => x.Category) // Inclui o author na query, inner join
        //    /*.Where(x => x.AuthorId == 1)*/ // aqui ele nao faz inner join => Author.Id (aqui faz o join)
        //    .OrderByDescending(x => x.LastUpdateDate)
        //    .ToList();

        //foreach (var post in posts)
        //{
        //    Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
        //}

        var posts = context
            .Posts
            //.AsNoTracking()
            .Include(x => x.Author) // Inclui o author na query, inner join
            .Include(x => x.Category) // Inclui o author na query, inner join
            /*.Where(x => x.AuthorId == 1)*/ // aqui ele nao faz inner join => Author.Id (aqui faz o join)
            .OrderByDescending(x => x.LastUpdateDate)
            .FirstOrDefault();

        posts.Author.Name = "Emanuel";
        context.Posts.Update(posts);
        context.SaveChanges();

    }
}