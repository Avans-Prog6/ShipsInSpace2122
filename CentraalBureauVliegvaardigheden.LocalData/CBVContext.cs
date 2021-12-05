using CentraalBureauVliegvaardigheden.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace CentraalBureauVliegvaardigheden.LocalData
{
    public class CBVContext : DbContext
    {
        public DbSet<Schip> Schepen { get; set; }
        public DbSet<Romp> Rompen { get; set; }
        public DbSet<Motor> Motoren { get; set; }
        public DbSet<Vleugel> Vleugels { get; set; }
        public DbSet<Wapen> Wapens { get; set; }

        public CBVContext(DbContextOptions<CBVContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wapen>().HasKey(e => e.Naam);
            modelBuilder.Entity<Wapen>().Property(w => w.SchadeType).HasConversion<string>();
            modelBuilder.Entity<Romp>().HasKey(e => e.Id);
            modelBuilder.Entity<Romp>().Property(r => r.Draagvermogen).HasConversion<string>();
            modelBuilder.Entity<Vleugel>().HasKey(e => e.Id);
            modelBuilder.Entity<Wapen>().Property(w => w.SchadeType).HasConversion<string>();

            #region Romp data
            modelBuilder.Entity<Romp>().HasData(new Romp
            { Id = 1, Naam = "Zenith", Draagvermogen = Draagvermogen.Interceptor });
            modelBuilder.Entity<Romp>().HasData(new Romp
            { Id = 2, Naam = "Neptunus", Draagvermogen = Draagvermogen.HeavyTank });
            modelBuilder.Entity<Romp>().HasData(new Romp
            { Id = 3, Naam = "Katalyst", Draagvermogen = Draagvermogen.Tank });
            modelBuilder.Entity<Romp>().HasData(new Romp
            { Id = 4, Naam = "Racewing", Draagvermogen = Draagvermogen.MediumFighter });
            #endregion

            #region Motor data
            modelBuilder.Entity<Motor>().HasData(
                new Motor { Id = 1, Naam = "Galaxy Class", Energie = 150, Gewicht = 150 },
                new Motor { Id = 2, Naam = "Intrepid Class", Energie = 350, Gewicht = 350 },
                new Motor { Id = 3, Naam = "Constellation Class", Energie = 200, Gewicht = 200 }
                );
            #endregion

            #region Vleugel data
            modelBuilder.Entity<Vleugel>().HasData(
                new Vleugel { Id = 1, Naam = "Blade", Energie = 0, NumberOfHardpoints = 2, Gewicht = 275 },
                new Vleugel { Id = 2, Naam = "Horizon", Energie = 0, NumberOfHardpoints = 1, Gewicht = 150 },
                new Vleugel { Id = 3, Naam = "D-Fence", Energie = 0, NumberOfHardpoints = 3, Gewicht = 300 },
                new Vleugel { Id = 4, Naam = "O-Fence", Energie = 15, NumberOfHardpoints = 2, Gewicht = 250 },
                new Vleugel { Id = 5, Naam = "Raceing", Energie = 0, NumberOfHardpoints = 1, Gewicht = 175 }
                );
            #endregion

            #region Wapen data
            modelBuilder.Entity<Wapen>().HasData(
                new Wapen { Naam = "Fury Cannon", Gewicht = 76, SchadeType = SchadeType.Hitte, EnergieVerbruik = 52 },
                new Wapen { Naam = "Crusher", Gewicht = 89, SchadeType = SchadeType.Zwaartekracht, EnergieVerbruik = 56 },
                new Wapen { Naam = "Flamethrower", Gewicht = 30, SchadeType = SchadeType.Hitte, EnergieVerbruik = 74 },
                new Wapen { Naam = "Freeze Ray", Gewicht = 24, SchadeType = SchadeType.Bevriezing, EnergieVerbruik = 52 },
                new Wapen { Naam = "Shockwave", Gewicht = 105, SchadeType = SchadeType.Projectiel, EnergieVerbruik = 47 },
                new Wapen { Naam = "Gauss Gun", Gewicht = 110, SchadeType = SchadeType.Projectiel, EnergieVerbruik = 52 },
                new Wapen { Naam = "Hailstorm", Gewicht = 34, SchadeType = SchadeType.Bevriezing, EnergieVerbruik = 56 },
                new Wapen { Naam = "Ice Barrage", Gewicht = 35, SchadeType = SchadeType.Bevriezing, EnergieVerbruik = 41 },
                new Wapen { Naam = "Imploder", Gewicht = 270, SchadeType = SchadeType.Zwaartekracht, EnergieVerbruik = 43 },
                new Wapen { Naam = "Levitator", Gewicht = 59, EnergieVerbruik = 56, SchadeType = SchadeType.Electrisch },
                new Wapen { Naam = "Shredder", Gewicht = 75, EnergieVerbruik = 13, SchadeType = SchadeType.Electrisch },
                new Wapen { Naam = "Tidal Wave", Gewicht = 18, SchadeType = SchadeType.Electrisch, EnergieVerbruik = 74 },
                new Wapen { Naam = "Volcano", Gewicht = 80, SchadeType = SchadeType.Hitte, EnergieVerbruik = 10, },
                new Wapen { Naam = "Nullifier", Gewicht = 23, SchadeType = SchadeType.Zwaartekracht, EnergieVerbruik = 43 }
                );
            #endregion
        }
    }
}
