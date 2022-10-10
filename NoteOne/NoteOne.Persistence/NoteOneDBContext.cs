using Microsoft.EntityFrameworkCore;
using NoteOne.Domain;

namespace NoteOne.Persistence
{
    public class NoteOneDBContext : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Note>? Notes { get; set; }
        public DbSet<Page>? Pages { get; set; } 
        public DbSet<Tag>? Tags  { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=NoteOne; Username=postgres; Password=postgres");
        } 
     }
}