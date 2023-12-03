using Humanizer.Bytes;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

using WebApplication2.Models;
namespace WebApplication2.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Membershiptype> Membershiptypes { get; set; }

        public AppDbContext(DbContextOptions options)
                : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {

            base.OnModelCreating(model);
            string GenreJSon = System.IO.File.ReadAllText("Genres.Json");
            List<Genre>? genres = System.Text.Json.
            JsonSerializer.Deserialize<List<Genre>>(GenreJSon);
            //Seed to categorie
            if (genres != null)
            {
                foreach (Genre c in genres)
                    model.Entity<Genre>()
                    .HasData(c);
            }
        }


    }
}