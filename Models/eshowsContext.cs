using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace e_shows.Models
{
    public partial class eshowsContext : DbContext
    {
        public eshowsContext()
        {
        }

        public eshowsContext(DbContextOptions<eshowsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; } = null!;
        public virtual DbSet<Cinema> Cinemas { get; set; } = null!;
        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<MovieCategory> MovieCategories { get; set; } = null!;
        public virtual DbSet<Producer> Producers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("Actor");

                entity.Property(e => e.ActId)
                    .ValueGeneratedNever()
                    .HasColumnName("ACT_ID");

                entity.Property(e => e.ActBio)
                    .IsUnicode(false)
                    .HasColumnName("ACT_Bio");

                entity.Property(e => e.ActImageUrl)
                    .IsUnicode(false)
                    .HasColumnName("ACT_Image_URL");

                entity.Property(e => e.ActName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ACT_Name");
            });

            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.HasKey(e => e.CId);

                entity.ToTable("Cinema");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("C_ID");

                entity.Property(e => e.CDescription).HasColumnName("C_Description");

                entity.Property(e => e.CLogo).HasColumnName("C_Logo");

                entity.Property(e => e.CName).HasColumnName("C_Name");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MId);

                entity.ToTable("Movie");

                entity.Property(e => e.MId)
                    .ValueGeneratedNever()
                    .HasColumnName("M_ID");

                entity.Property(e => e.MDescription).HasColumnName("M_Description");

                entity.Property(e => e.MEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("M_EndDate");

                entity.Property(e => e.MImageUrl).HasColumnName("M_Image_URL");

                entity.Property(e => e.MName).HasColumnName("M_Name");

                entity.Property(e => e.MPrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("M_Price");

                entity.Property(e => e.MStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("M_StartDate");

                entity.Property(e => e.McCategory)
                    .HasMaxLength(50)
                    .HasColumnName("MC_Category");
            });

            modelBuilder.Entity<MovieCategory>(entity =>
            {
                entity.HasKey(e => e.McId);

                entity.ToTable("MovieCategory");

                entity.Property(e => e.McId)
                    .ValueGeneratedNever()
                    .HasColumnName("MC_ID");

                entity.Property(e => e.McCategory)
                    .HasMaxLength(50)
                    .HasColumnName("MC_Category");
            });

            modelBuilder.Entity<Producer>(entity =>
            {
                entity.HasKey(e => e.PId);

                entity.ToTable("Producer");

                entity.Property(e => e.PId)
                    .ValueGeneratedNever()
                    .HasColumnName("P_ID");

                entity.Property(e => e.PBio).HasColumnName("P_Bio");

                entity.Property(e => e.PImageUrl).HasColumnName("P_Image_URL");

                entity.Property(e => e.PName).HasColumnName("P_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
