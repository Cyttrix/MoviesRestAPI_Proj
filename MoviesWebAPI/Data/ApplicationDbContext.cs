using Microsoft.EntityFrameworkCore;
using MoviesWebAPI.Models;

namespace MoviesWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        
        }
    }
}
