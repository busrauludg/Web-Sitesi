using Microsoft.EntityFrameworkCore;

namespace GorevYonetim.Models
{
    public class RepositoryContext:DbContext
    {
        public DbSet<User>Users { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext>options)
        :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
            .HasData(
                new User() {UserId=1,UserName="Aylin",Email="kntktk",Password="111"}
            
            );
        }
    }
}