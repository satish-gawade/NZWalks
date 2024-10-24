using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    //inherit from the dbContext class
    public class NZWalksDbContext : DbContext
    {
        //create a constructor
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }


        // creat dbset property for each domain-A DbSet represents the collection of all entities in the
        // context, or that can be queried from the database, of a given type.

        public DbSet<Difficulty> Difficullties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walks> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data for Difficulties
            //Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("965ca9aa-ede5-4d5e-9953-425825fbb26a"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("85e2bf78-c201-413c-af46-72ae1be9bcd4"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("0d4317b2-5240-434a-9418-4ca70061abcc"),
                    Name = "Hard"
                }
           };

            //seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);



            //Seed data for Regions
            var regions = new List<Region>()
            {
                new Region
                {
                    Id = Guid.Parse("b74fcc6d-e2f4-4fd5-a228-15f00b13ee49"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://example.com/images/auckland.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("e678c8a4-5c92-4c98-8d22-36f30fdff920"),
                    Name = "Wellington",
                    Code = "WLG",
                    RegionImageUrl = "https://example.com/images/wellington.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("8a3570ad-92c1-4b8d-a5bc-2cf2a8e030fb"),
                    Name = "Christchurch",
                    Code = "CHC",
                    RegionImageUrl = "https://example.com/images/christchurch.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("f3b29cb1-eeb6-4b67-9f57-46cbb68fbbdf"),
                    Name = "Hamilton",
                    Code = "HLZ",
                    RegionImageUrl = "https://example.com/images/hamilton.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("fa4d23ff-e52e-4b64-8e9e-29a2a1e5f993"),
                    Name = "Tauranga",
                    Code = "TRG",
                    RegionImageUrl = "https://example.com/images/tauranga.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("d467fea9-cc5c-4855-8fd5-88d9f2d1ff1d"),
                    Name = "Napier",
                    Code = "NPE",
                    RegionImageUrl = "https://example.com/images/napier.jpg"
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}