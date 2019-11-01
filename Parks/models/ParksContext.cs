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
                    new Park { ParkId = 3, Name = "Grand Canyon",  StateOrNational = "National", State="AZ", Rating = 4 },
                    new Park { ParkId = 4, Name = "Joshua Tree",  StateOrNational = "National", State="CA", Rating = 10 },
                    new Park { ParkId = 5, Name = "Lake Tahoe",  StateOrNational = "State", State="NV", Rating = 9 },
                    new Park { ParkId = 6, Name = "Rocky Mounatin",  StateOrNational = "National", State="CO", Rating = 5 },
                    new Park { ParkId = 7, Name = "Yellowstone",  StateOrNational = "National", State="ID", Rating = 2 },
                    new Park { ParkId = 8, Name = "Haleakala",  StateOrNational = "National", State="HI", Rating = 8 },
                    new Park { ParkId = 9, Name = "Mammoth Cave",  StateOrNational = "National", State="KY", Rating = 6 },
                    new Park { ParkId = 10, Name = "Glacier",  StateOrNational = "National", State="MT", Rating = 10 },
                    new Park { ParkId = 11, Name = "Goblin Valley",  StateOrNational = "State", State="UT", Rating = 10 },
                    new Park { ParkId = 12, Name = "Arches",  StateOrNational = "National", State="UT", Rating = 10 },
                    new Park { ParkId = 13, Name = "BadLands",  StateOrNational = "National", State= "SD", Rating = 9 },
                    new Park { ParkId = 14, Name = "Bryce Canyon",  StateOrNational = "National", State="UT", Rating = 10 },
                    new Park { ParkId = 15, Name = "Carlsbad Caverns",  StateOrNational = "National", State="NM", Rating = 8 },
                    new Park { ParkId = 16, Name = "Grand Teton",  StateOrNational = "National", State="WY", Rating = 3 },
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
                    new Park { ParkId = 28, Name = "Tombigbee",  StateOrNational = "State", State="MS", Rating = 6 },
                    new Park { ParkId = 29, Name = "Little Missouri",  StateOrNational = "State", State="MO", Rating = 8 },
                    new Park { ParkId = 30, Name = "Shenandoah",  StateOrNational = "National", State="VA", Rating = 8 },
                    new Park { ParkId = 31, Name = "DeSoto",  StateOrNational = "State", State="AL", Rating = 2 },
                    new Park { ParkId = 32, Name = "Acadia",  StateOrNational = "National", State="ME", Rating = 7 },
                    new Park { ParkId = 33, Name = "Biscayne",  StateOrNational = "National", State= "FL", Rating = 5 },
                    new Park { ParkId = 34, Name = "Cuyahoga Valley",  StateOrNational = "National", State="OH", Rating = 4 },
                    new Park { ParkId = 35, Name = "Everglades",  StateOrNational = "National", State="FL", Rating = 7 },
                    new Park { ParkId = 36, Name = "Oak Mountain",  StateOrNational = "State", State="AL", Rating = 6 },
                    new Park { ParkId = 37, Name = "Borderland",  StateOrNational = "State", State="MA", Rating = 8 },
                    new Park { ParkId = 38, Name = "Burlingame",  StateOrNational = "State", State="RI", Rating = 9 },
                    new Park { ParkId = 39, Name = "Camel's Hump",  StateOrNational = "State", State="VT", Rating = 10 },
                    new Park { ParkId = 40, Name = "Green River Resevoir",  StateOrNational = "State", State="VT", Rating = 3 },
                    new Park { ParkId = 41, Name = "Gates of the Arctic",  StateOrNational = "National", State="AK", Rating = 10 },
                    new Park { ParkId = 42, Name = "Great Basin",  StateOrNational = "National", State="NV", Rating = 6 },
                    new Park { ParkId = 43, Name = "Great Sand Dunes",  StateOrNational = "National", State= "CO", Rating = 9 },
                    new Park { ParkId = 44, Name = "High Falls",  StateOrNational = "National", State="GA", Rating = 6 },
                    new Park { ParkId = 45, Name = "Isle Royale",  StateOrNational = "National", State="MI", Rating = 7 },
                    new Park { ParkId = 46, Name = "Katmai",  StateOrNational = "National", State="AK", Rating = 8 },
                    new Park { ParkId = 47, Name = "Olympic",  StateOrNational = "National", State="WA", Rating = 10 },
                    new Park { ParkId = 48, Name = "Petrified Forest",  StateOrNational = "National", State="AZ", Rating = 9 },
                    new Park { ParkId = 49, Name = "Wind Cave",  StateOrNational = "National", State="SD", Rating = 3 },
                    new Park { ParkId = 50, Name = "Indiana Dunes",  StateOrNational = "State", State="IN", Rating = 4 }
                );
        }
    }
}