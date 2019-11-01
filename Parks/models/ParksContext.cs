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
                    new Park { ParkId = 1, Name = "SamuelPTaylor",  StateOrNational = "State", State="CA", Rating = 10, Activities="Trail running, birdwatching"},
                    new Park { ParkId = 2, Name = "Denali",  StateOrNational = "National", State="AK", Rating = 10, Activities="Snowshoeing, snowman-building"},
                    new Park { ParkId = 3, Name = "Grand Canyon",  StateOrNational = "National", State="AZ", Rating = 4, Activities="Hiking, picnicking"},
                    new Park { ParkId = 4, Name = "Joshua Tree",  StateOrNational = "National", State="CA", Rating = 10, Activities="Rock-climbing"},
                    new Park { ParkId = 5, Name = "Lake Tahoe",  StateOrNational = "State", State="NV", Rating = 9, Activities="Fishing, swimming, trail-running"},
                    new Park { ParkId = 6, Name = "Rocky Mounatin",  StateOrNational = "National", State="CO", Rating = 5, Activities="Hiking, running, mountaineering"},
                    new Park { ParkId = 7, Name = "Yellowstone",  StateOrNational = "National", State="ID", Rating = 2, Activities="Backpacking, hiking"},
                    new Park { ParkId = 8, Name = "Haleakala",  StateOrNational = "National", State="HI", Rating = 8, Activities="Coconut-hunting, cycling"},
                    new Park { ParkId = 9, Name = "Mammoth Cave",  StateOrNational = "National", State="KY", Rating = 6, Activities="Running, bat-watching"},
                    new Park { ParkId = 10, Name = "Glacier",  StateOrNational = "National", State="MT", Rating = 10, Activities="Trekking, kayaking"},
                    new Park { ParkId = 11, Name = "Goblin Valley",  StateOrNational = "State", State="UT", Rating = 10, Activities="Rock-climbing, hiking,"},
                    new Park { ParkId = 12, Name = "Arches",  StateOrNational = "National", State="UT", Rating = 10, Activities="Hiking, sun-bathing"},
                    new Park { ParkId = 13, Name = "BadLands",  StateOrNational = "National", State= "SD", Rating = 9, Activities="Trail running, hiking"},
                    new Park { ParkId = 14, Name = "Bryce Canyon",  StateOrNational = "National", State="UT", Rating = 10, Activities="Hiking, exploring"},
                    new Park { ParkId = 15, Name = "Carlsbad Caverns",  StateOrNational = "National", State="NM", Rating = 8, Activities="Hiking, walking, squeezing"},
                    new Park { ParkId = 16, Name = "Grand Teton",  StateOrNational = "National", State="WY", Rating = 3, Activities="Trail running, mountain-ogling"},
                    new Park { ParkId = 17, Name = "Congaree",  StateOrNational = "National", State="SC", Rating = 7, Activities="Running, walking, crawling"},
                    new Park { ParkId = 18, Name = "Crater Lake",  StateOrNational = "National", State="OR", Rating = 10, Activities="Boating, hiking, picnicking"},
                    new Park { ParkId = 19, Name = "Great Smoky Mountains",  StateOrNational = "National", State="TN", Rating = 9, Activities="Mountaineering, skyrunning"},
                    new Park { ParkId = 20, Name = "Guadalupe Mountains",  StateOrNational = "National", State="TX", Rating = 7, Activities="Sight-seeing, picnicking"},
                    new Park { ParkId = 21, Name = "Voyageurs",  StateOrNational = "National", State="MN", Rating = 8, Activities="Trekking, waterfalls"},
                    new Park { ParkId = 22, Name = "Big Creek",  StateOrNational = "State", State="IA", Rating = 7, Activities="Swimming, walking, cartwheeling"},
                    new Park { ParkId = 23, Name = "Cheboygan",  StateOrNational = "State", State= "MI", Rating = 9, Activities="Trail running, camping"},
                    new Park { ParkId = 24, Name = "Joaquin Miller",  StateOrNational = "State", State="CA", Rating = 10, Activities="Mountain biking, hiking, sunset-viewing"},
                    new Park { ParkId = 25, Name = "Carlsbad Caverns",  StateOrNational = "National", State="NM", Rating = 8, Activities="Running, bird-watching"},
                    new Park { ParkId = 26, Name = "Zion",  StateOrNational = "National", State="UT", Rating = 10, Activities="Running, hiking, climbing, swimming"},
                    new Park { ParkId = 27, Name = "Arrowhead",  StateOrNational = "State", State="OK", Rating = 7, Activities="Mountaineering, hiking"},
                    new Park { ParkId = 28, Name = "Tombigbee",  StateOrNational = "State", State="MS", Rating = 6, Activities="Rock-climbing, camping"},
                    new Park { ParkId = 29, Name = "Little Missouri",  StateOrNational = "State", State="MO", Rating = 8, Activities="Cycling, camping, bird-watching"},
                    new Park { ParkId = 30, Name = "Shenandoah",  StateOrNational = "National", State="VA", Rating = 8, Activities="Mountain biking, backpacking"},
                    new Park { ParkId = 31, Name = "DeSoto",  StateOrNational = "State", State="AL", Rating = 2, Activities="Cycling, canoeing"},
                    new Park { ParkId = 32, Name = "Acadia",  StateOrNational = "National", State="ME", Rating = 7, Activities="Swimming, clam digging"},
                    new Park { ParkId = 33, Name = "Biscayne",  StateOrNational = "National", State= "FL", Rating = 5, Activities="Mushroom foraging, hiking"},
                    new Park { ParkId = 34, Name = "Cuyahoga Valley",  StateOrNational = "National", State="OH", Rating = 4, Activities="Trekking, camping"},
                    new Park { ParkId = 35, Name = "Everglades",  StateOrNational = "National", State="FL", Rating = 7, Activities="Plogging, skyrunning"},
                    new Park { ParkId = 36, Name = "Oak Mountain",  StateOrNational = "State", State="AL", Rating = 6, Activities="Running, bird-watching"},
                    new Park { ParkId = 37, Name = "Borderland",  StateOrNational = "State", State="MA", Rating = 8, Activities="Canyoning, Skiing, hiking"},
                    new Park { ParkId = 38, Name = "Burlingame",  StateOrNational = "State", State="RI", Rating = 9, Activities="Trail running, birdwatching, paragliding"},
                    new Park { ParkId = 39, Name = "Camel's Hump",  StateOrNational = "State", State="VT", Rating = 10, Activities="Fly fishing, kayaking"},
                    new Park { ParkId = 40, Name = "Green River Resevoir",  StateOrNational = "State", State="VT", Rating = 3, Activities="Rappelling, hiking"},
                    new Park { ParkId = 41, Name = "Gates of the Arctic",  StateOrNational = "National", State="AK", Rating = 10, Activities="Skiing, snowshoeing"},
                    new Park { ParkId = 42, Name = "Great Basin",  StateOrNational = "National", State="NV", Rating = 6, Activities="Camping, backpacking, train running"},
                    new Park { ParkId = 43, Name = "Great Sand Dunes",  StateOrNational = "National", State= "CO", Rating = 9, Activities="Mountain biking, rock climbing"},
                    new Park { ParkId = 44, Name = "High Falls",  StateOrNational = "National", State="GA", Rating = 6, Activities="Clam digging, swimming, sailing"},
                    new Park { ParkId = 45, Name = "Isle Royale",  StateOrNational = "National", State="MI", Rating = 7, Activities="Windsurfing, birdwatching"},
                    new Park { ParkId = 46, Name = "Katmai",  StateOrNational = "National", State="AK", Rating = 8, Activities="Ice climbing, running, birdwatching"},
                    new Park { ParkId = 47, Name = "Olympic",  StateOrNational = "National", State="WA", Rating = 10, Activities="Trekking, running, hiking"},
                    new Park { ParkId = 48, Name = "Petrified Forest",  StateOrNational = "National", State="AZ", Rating = 9, Activities="Mushroom foraging, plogging, tree climbing"},
                    new Park { ParkId = 49, Name = "Wind Cave",  StateOrNational = "National", State="SD", Rating = 3, Activities="Paragliding, wingsuit flying"},
                    new Park { ParkId = 50, Name = "Indiana Dunes",  StateOrNational = "State", State="IN", Rating = 4, Activities="Motorbike expedition, sightseeing"}
                );
        }
    }
}