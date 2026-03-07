using Microsoft.EntityFrameworkCore;
namespace LibraryBookManagementSystem.Models
{
    public class LibraryDbContext:DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options):base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
    }
}
