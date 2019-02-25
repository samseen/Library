using LibraryData.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public DbSet<Patron> Patrons { get; set; }
        public LibraryContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
