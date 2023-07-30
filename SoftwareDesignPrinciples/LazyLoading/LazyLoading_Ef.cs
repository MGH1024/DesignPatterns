namespace SoftwareDesignPrinciples.LazyLoading;

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public virtual Author Author { get; set; }
}


////////////////////////////////////////////////////////////
using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Replace "Your_Connection_String" with your actual database connection string
        optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Your_Connection_String");
    }
}

//////////////
/// using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        using (var context = new LibraryContext())
        {
            // Retrieve an author from the database (lazy loading enabled)
            var author = context.Authors.FirstOrDefault(a => a.AuthorId == 1);

            if (author != null)
            {
                // Access the Books property (lazy loading occurs here)
                foreach (var book in author.Books)
                {
                    Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}");
                }
            }
        }
    }
}
