using DAL.Concrete.Context.Configurations;
using Entities;
using Microsoft.EntityFrameworkCore;


namespace DAL.Concrete.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ActorConfiguration())
                .ApplyConfiguration(new CinemaConfiguration())
                .ApplyConfiguration(new ProducerConfiguration())
                .ApplyConfiguration(new MovieConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server = YAVUZ-PC\SQLSERVER2019; Database = Ecommerce-app-db; Trusted_Connection = True;");
        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Movie> Movies { get; set; }
    }
}
