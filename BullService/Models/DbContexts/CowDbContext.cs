using BullService.Models.Cow;
using Microsoft.EntityFrameworkCore;
using System;

namespace BullService.Models.DbContexts
{
    public class CowDbContext : DbContext
    {
        //Define DbSets
        public DbSet<CowModel> Cows { get; set; }
        public DbSet<CowMeasurementModel> CowMeasurements { get; set; }

        public DbSet<PictureModel> CowPictures { get; set; }

        public CowDbContext(DbContextOptions<CowDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PictureModel>()
            .Property(e => e.PicturePaths)
            .HasConversion(
                v => string.Join(',', v),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries));
            modelBuilder.Entity<CowModel>()
                .HasMany(c => c.CowMeasurements)
                .WithOne(e => e.Cow);
        }
    }
}
