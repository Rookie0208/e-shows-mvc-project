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

        public virtual DbSet<Actor> Actor { get; set; } = null!;
        public virtual DbSet<ActorMovie> ActorMovies { get; set; } = null!;
        public virtual DbSet<Artist> Artists { get; set; } = null!;
        public virtual DbSet<CategoryDetail> CategoryDetails { get; set; } = null!;
        public virtual DbSet<CategoryMaster> CategoryMasters { get; set; } = null!;
        public virtual DbSet<Cinema> Cinemas { get; set; } = null!;
        public virtual DbSet<DepartmentDetail> DepartmentDetails { get; set; } = null!;
        public virtual DbSet<LocationDetail> LocationDetails { get; set; } = null!;
        public virtual DbSet<Movie> Movie { get; set; } = null!;
        public virtual DbSet<Producer> Producer { get; set; } = null!;

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

            modelBuilder.Entity<ActorMovie>(entity =>
            {
                entity.HasKey(e => e.AmId);

                entity.ToTable("ActorMovie");

                entity.Property(e => e.AmId)
                    .ValueGeneratedNever()
                    .HasColumnName("AM_ID");

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.MId).HasColumnName("M_ID");

                entity.HasOne(d => d.Am)
                    .WithOne(p => p.ActorMovie)
                    .HasForeignKey<ActorMovie>(d => d.AmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActorMovie_Actor");

                entity.HasOne(d => d.MIdNavigation)
                    .WithMany(p => p.ActorMovies)
                    .HasForeignKey(d => d.MId)
                    .HasConstraintName("FK_ActorMovie_Movie");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Artist");

                entity.Property(e => e.ArtBio).HasColumnName("ART_Bio");

                entity.Property(e => e.ArtId).HasColumnName("ART_ID");

                entity.Property(e => e.ArtImageUrl).HasColumnName("ART_Image_URL");

                entity.Property(e => e.ArtName)
                    .HasMaxLength(200)
                    .HasColumnName("ART_Name");
            });

            modelBuilder.Entity<CategoryDetail>(entity =>
            {
                entity.HasKey(e => e.CtId);

                entity.ToTable("CategoryDetail");

                entity.Property(e => e.CtId)
                    .ValueGeneratedNever()
                    .HasColumnName("CT_ID");

                entity.Property(e => e.CmId).HasColumnName("CM_ID");

                entity.Property(e => e.CtCdt)
                    .HasColumnType("datetime")
                    .HasColumnName("CT_CDT");

                entity.Property(e => e.CtIsActive).HasColumnName("CT_IsActive");

                entity.Property(e => e.CtMdt)
                    .HasColumnType("datetime")
                    .HasColumnName("CT_MDT");

                entity.Property(e => e.CtName)
                    .HasMaxLength(200)
                    .HasColumnName("CT_Name");

                entity.HasOne(d => d.Cm)
                    .WithMany(p => p.CategoryDetails)
                    .HasForeignKey(d => d.CmId)
                    .HasConstraintName("FK_CategoryDetail_CategoryMaster");
            });

            modelBuilder.Entity<CategoryMaster>(entity =>
            {
                entity.HasKey(e => e.CmId);

                entity.ToTable("CategoryMaster");

                entity.Property(e => e.CmId)
                    .ValueGeneratedNever()
                    .HasColumnName("CM_ID");

                entity.Property(e => e.CmName)
                    .HasMaxLength(50)
                    .HasColumnName("CM_Name");
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

            modelBuilder.Entity<DepartmentDetail>(entity =>
            {
                entity.HasKey(e => e.DpId);

                entity.ToTable("DepartmentDetail");

                entity.Property(e => e.DpId)
                    .ValueGeneratedNever()
                    .HasColumnName("DP_ID");

                entity.Property(e => e.DpCdt)
                    .HasColumnType("datetime")
                    .HasColumnName("DP_CDT");

                entity.Property(e => e.DpIsActive).HasColumnName("DP_IsActive");

                entity.Property(e => e.DpMdt)
                    .HasColumnType("datetime")
                    .HasColumnName("DP_MDT");

                entity.Property(e => e.DpName).HasColumnName("DP_Name");

                entity.Property(e => e.LcId).HasColumnName("LC_ID");
            });

            modelBuilder.Entity<LocationDetail>(entity =>
            {
                entity.HasKey(e => e.LcId);

                entity.ToTable("LocationDetail");

                entity.Property(e => e.LcId)
                    .ValueGeneratedNever()
                    .HasColumnName("LC_ID");

                entity.Property(e => e.LcCdt)
                    .HasColumnType("datetime")
                    .HasColumnName("LC_CDT");

                entity.Property(e => e.LcCountry)
                    .HasMaxLength(50)
                    .HasColumnName("LC_Country");

                entity.Property(e => e.LcIsActive).HasColumnName("LC_IsActive");

                entity.Property(e => e.LcMdt)
                    .HasColumnType("datetime")
                    .HasColumnName("LC_MDT");

                entity.Property(e => e.LcName)
                    .HasMaxLength(200)
                    .HasColumnName("LC_Name");
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
