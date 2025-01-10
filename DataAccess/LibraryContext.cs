using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class LibraryContext(DbContextOptions<LibraryContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
}
