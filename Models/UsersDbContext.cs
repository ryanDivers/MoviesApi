using Microsoft.EntityFrameworkCore;

namespace MoviesApi.Models
{
    public class UsersDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
