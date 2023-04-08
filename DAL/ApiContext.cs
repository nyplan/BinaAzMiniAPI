using BinaAzAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BinaAzAPI.DAL
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region EnumKey Seed

            modelBuilder.Entity<EnumKey>().HasData(
                new EnumKey()
                {
                    Id = 1,
                    Key = "apartmentType"
                },
                new EnumKey()
                {
                    Id = 2,
                    Key = "actionType"
                },
                new EnumKey()
                {
                    Id = 3,
                    Key = "rooms"
                },
                new EnumKey()
                {
                    Id = 4,
                    Key = "pricePerDayMonth"
                },
                new EnumKey()
                {
                    Id = 5,
                    Key = "repair"
                },
                new EnumKey()
                {
                    Id = 6,
                    Key = "adOwner"
                });

            #endregion

            #region EnumValue Seed

            modelBuilder.Entity<EnumValue>().HasData(
                new EnumValue()
                {
                    Id = 1,
                    KeyId = 1,
                    Value = "New Building"
                },
                new EnumValue()
                {
                    Id = 2,
                    KeyId = 1,
                    Value = "Old Building"
                },
                new EnumValue()
                {
                    Id = 3,
                    KeyId = 2,
                    Value = "I Sell"
                },
                new EnumValue()
                {
                    Id = 4,
                    KeyId = 2,
                    Value = "I Rent"
                },
                new EnumValue()
                {
                    Id = 5,
                    KeyId = 3,
                    Value = "1 room"
                },
                new EnumValue()
                {
                    Id = 6,
                    KeyId = 3,
                    Value = "2 rooms"
                },
                new EnumValue()
                {
                    Id = 7,
                    KeyId = 3,
                    Value = "3 rooms"
                },
                new EnumValue()
                {
                    Id = 8,
                    KeyId = 3,
                    Value = "4 rooms"
                },
                new EnumValue()
                {
                    Id = 9,
                    KeyId = 3,
                    Value = "5 rooms"
                },
                new EnumValue()
                {
                    Id = 10,
                    KeyId = 3,
                    Value = "6 rooms"
                },
                new EnumValue()
                {
                    Id = 11,
                    KeyId = 4,
                    Value = "Per Day"
                },
                new EnumValue()
                {
                    Id = 12,
                    KeyId = 4,
                    Value = "Per Month"
                },
                new EnumValue()
                {
                    Id = 13,
                    KeyId = 5,
                    Value = "Repaired"
                },
                new EnumValue()
                {
                    Id = 14,
                    KeyId = 5,
                    Value = "Unrepaired"
                },
                new EnumValue()
                {
                    Id = 15,
                    KeyId = 6,
                    Value = "I am the Owner"
                },
                new EnumValue()
                {
                    Id = 16,
                    KeyId = 6,
                    Value = "I am an Agent"
                });

            #endregion

            #region City Seed

            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Name = "Baku"
                });

            #endregion

            #region District Seed

            modelBuilder.Entity<District>().HasData(
                new District()
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Nerimanov"
                });

            #endregion

            #region Township Seed

            modelBuilder.Entity<Township>().HasData(
                new Township()
                {
                    Id = 1,
                    DistrictId = 1,
                    Name = "Boyukshor"
                });

            #endregion

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Township> Townships { get; set; }
        public DbSet<EnumKey> EnumKeys { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Picture> Pictures { get; set; }
    }
}
