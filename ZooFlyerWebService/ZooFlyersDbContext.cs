using ZooFlyerWebService.Models;

namespace ZooFlyerWebService
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ZooFlyersDbContext : DbContext
    {
        public ZooFlyersDbContext()
            : base("name=ZooFlyersDbContext")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<Flyer> Flyers { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<OpeningHour> OpeningHours { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.Street)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .HasMany(e => e.Flyers)
                .WithRequired(e => e.Address1)
                .HasForeignKey(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .Property(e => e.City1)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.City)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Day>()
                .Property(e => e.Day1)
                .IsUnicode(false);

            modelBuilder.Entity<Day>()
                .HasMany(e => e.OpeningHours)
                .WithRequired(e => e.Day1)
                .HasForeignKey(e => e.Day)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Image>()
                .HasMany(e => e.Flyers)
                .WithRequired(e => e.Image)
                .HasForeignKey(e => e.Pics)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OpeningHour>()
                .Property(e => e.Open)
                .HasPrecision(0);

            modelBuilder.Entity<OpeningHour>()
                .Property(e => e.Close)
                .HasPrecision(0);

            modelBuilder.Entity<OpeningHour>()
                .HasMany(e => e.Flyers)
                .WithRequired(e => e.OpeningHour)
                .HasForeignKey(e => e.OpeningHours)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Price>()
                .HasMany(e => e.Flyers)
                .WithRequired(e => e.Price1)
                .HasForeignKey(e => e.Price)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Season>()
                .Property(e => e.Season1)
                .IsUnicode(false);

            modelBuilder.Entity<Season>()
                .HasMany(e => e.OpeningHours)
                .WithRequired(e => e.Season1)
                .HasForeignKey(e => e.Season)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Flyers)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
