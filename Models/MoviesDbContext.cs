using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;
 
namespace MoviesApi.Models
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }


        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
        public DbSet<MoviesApi.Models.User> User { get; set; }
    }
}
