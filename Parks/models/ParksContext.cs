using Microsoft.EntityFrameworkCore;

namespace Parks.Models
{
    public class ParksContext : DbContext
    {
        public ParksContext(DbContextOptions<ParksContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "SamuelPTaylor",  StateOrNational = "State", State="CA", Rating = 10 },
                    new Park { ParkId = 2, Name = "Denali",  StateOrNational = "National", State="AK", Rating = 10 },
                    new Park { ParkId = 3, Name = "Grand Canyon",  StateOrNational = "National", State="AZ", Rating = 9 },
                    new Park { ParkId = 4, Name = "Joshua Tree",  StateOrNational = "National", State="CA", Rating = 10 },
                    new Park { ParkId = 5, Name = "Lake Tahoe",  StateOrNational = "State", State="NV", Rating = 10 },
                    new Park { ParkId = 6, Name = "Rocky Mounatin",  StateOrNational = "National", State="CO", Rating = 10 },
                    new Park { ParkId = 7, Name = "Yellowstone",  StateOrNational = "National", State="ID", Rating = 10 },
                    new Park { ParkId = 8, Name = "Haleakala",  StateOrNational = "National", State="HI", Rating = 8 },
                    new Park { ParkId = 9, Name = "Mammoth Cave",  StateOrNational = "National", State="KY", Rating = 10 },
                    new Park { ParkId = 10, Name = "Glacier",  StateOrNational = "National", State="MT", Rating = 10 },
                    new Park { ParkId = 11, Name = "Goblin Valley",  StateOrNational = "State", State="UT", Rating = 10 },
                    new Park { ParkId = 12, Name = "Arches",  StateOrNational = "National", State="UT", Rating = 10 },
                    new Park { ParkId = 13, Name = "BadLands",  StateOrNational = "National", State= "SD", Rating = 9 },
                    new Park { ParkId = 14, Name = "Bryce Canyon",  StateOrNational = "National", State="UT", Rating = 10 },
                    new Park { ParkId = 15, Name = "Carlsbad Caverns",  StateOrNational = "National", State="NM", Rating = 8 },
                    new Park { ParkId = 16, Name = "Grand Teton",  StateOrNational = "National", State="WY", Rating = 10 },
                    new Park { ParkId = 17, Name = "Congaree",  StateOrNational = "National", State="SC", Rating = 7 },
                    new Park { ParkId = 18, Name = "Crater Lake",  StateOrNational = "National", State="OR", Rating = 10 },
                    new Park { ParkId = 19, Name = "Great Smoky Mountains",  StateOrNational = "National", State="TN", Rating = 9 },
                    new Park { ParkId = 20, Name = "Guadalupe Mountains",  StateOrNational = "National", State="TX", Rating = 7 },
                    new Park { ParkId = 21, Name = "Voyageurs",  StateOrNational = "National", State="MN", Rating = 8 },
                    new Park { ParkId = 22, Name = "Big Creek",  StateOrNational = "State", State="IA", Rating = 7 },
                    new Park { ParkId = 23, Name = "Cheboygan",  StateOrNational = "State", State= "MI", Rating = 9 },
                    new Park { ParkId = 24, Name = "Joaquin Miller",  StateOrNational = "State", State="CA", Rating = 10 },
                    new Park { ParkId = 25, Name = "Carlsbad Caverns",  StateOrNational = "National", State="NM", Rating = 8 },
                    new Park { ParkId = 26, Name = "Zion",  StateOrNational = "National", State="UT", Rating = 10 },
                    new Park { ParkId = 27, Name = "Arrowhead",  StateOrNational = "State", State="OK", Rating = 7 },
                    new Park { ParkId = 28, Name = "Tombigbee",  StateOrNational = "State", State="MS", Rating = 10 },
                    new Park { ParkId = 29, Name = "Little Missouri",  StateOrNational = "State", State="MO", Rating = 8 },
                    new Park { ParkId = 30, Name = "Shenandoah",  StateOrNational = "National", State="VA", Rating = 8 }
                    
                );
        }



    }
}