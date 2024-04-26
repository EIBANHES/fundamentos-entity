using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new BlogDataContext())
        {
            //var tag = new Tag { Name = "test", Slug = "slug" };

            //context.Tags.Add(tag);
            // Salva no banco
            //context.SaveChanges();

            //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
            //tag.Name = "Oi";
            //tag.Slug = "Emanuel";
            //context.Update(tag);
            //context.SaveChanges();
            //Nunca com AsNoTracking
            //var tag = context
            //    .Tags
            //    .FirstOrDefault(x => x.Id == 2);
            //tag.Name = "Oi";
            //tag.Slug = "Emanuel";
            //context.Remove(tag);
            //context.SaveChanges();

            //AsNoTracking -> importante para performance
            //var tags = context.Tags.AsNoTracking().ToList(); //ToList() sempre no final da query

            //foreach (var tag in tags)
            //{
            //    Console.WriteLine(tag.Name);
            //}

            var tag = context
                .Tags
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == 2);
            Console.WriteLine(tag?.Name);
        }
    }
}