using Microsoft.EntityFrameworkCore;
using PhoneSystem___LOLDESIGN.Models;

namespace PhoneSystem___LOLDESIGN.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Relation> Relation { get; set; }
    
        public DataContext()
        {
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relation>()
                .HasData(new List<Relation>(){
                    new Relation(1, 011 , 016,1.9),
                    new Relation(2, 016 , 011,2.9),
                    new Relation(3, 011 , 017,1.7),
                    new Relation(4, 017 , 011,2.7),
                    new Relation(5, 011 , 018,0.9),
                    new Relation(6, 018 , 011,1.9),
                });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("TrustServerCertificate=True;Password=mateus02;Persist Security Info=True;User ID=sa;Initial Catalog=PhoneSystem;Data Source=DESKTOP-INCE99I");
            }
        }
    }
}

