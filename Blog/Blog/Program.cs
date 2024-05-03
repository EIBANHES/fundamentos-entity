using Blog.Data;
using Blog.Models;

class Program
{
    static void Main(string[] args)
    {
        using var context = new BlogDataContext();
    }
}