using Microsoft.EntityFrameworkCore;

namespace BookStore.Models
{
    public class BookContent : DbContext
    {
        public BookContent(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
