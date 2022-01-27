using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base(options) 
        { 
        
        }

        public DbSet<NewMovie> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovie>().HasData(
                
                new NewMovie
                {
                    film_id = 1,
                    category = "Action/Adventure",
                    title = "Casino Royale",
                    year = 2006,
                    director = "John Doe",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "",
                    notes = ""
                },
                new NewMovie
                {
                    film_id = 2,
                    category = "Action/Adventure",
                    title = "Skyfall",
                    year = 2013,
                    director = "John Doe",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "",
                    notes = ""
                },
                new NewMovie
                {
                    film_id = 3,
                    category = "Action/Adventure",
                    title = "No Time To Die",
                    year = 2021,
                    director = "John Doe",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "",
                    notes = ""
                }
            );
        }
    }
}
