using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReciPicker.Models
{
    public partial class recipickerContext : DbContext
    {
        public recipickerContext()
        {
        }

        public recipickerContext(DbContextOptions<recipickerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Filters> Filters { get; set; }
        public virtual DbSet<RecipeDetails> RecipeDetails { get; set; }
        public virtual DbSet<RecipeFilterRelation> RecipeFilterRelation { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<UserFavouriteRecipes> UserFavouriteRecipes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=recipicker.database.windows.net;Database=ReciPicker;User Id=larenall;Password=C9s0v0yf;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filters>(entity =>
            {
                entity.HasKey(e => e.FilterId)
                    .HasName("PK__filters__A7FEC0DAE7038C33");

                entity.ToTable("filters");

                entity.Property(e => e.FilterId).HasColumnName("filterID");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecipeDetails>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__RecDet");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.ToTable("recipeDetails");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasColumnName("method")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RecipeId).HasColumnName("recipeID");


            });

            modelBuilder.Entity<RecipeFilterRelation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__RecFilRel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.ToTable("recipeFilterRelation");
                

                entity.Property(e => e.FilterId).HasColumnName("filterID");

                entity.Property(e => e.RecipeId).HasColumnName("recipeID");

                entity.Property(e => e.IsChecked).HasColumnName("checked");



            });

            modelBuilder.Entity<Recipe>(entity =>
            {
                entity.HasKey(e => e.RecipeId)
                    .HasName("PK__recipes__C114EE6364C181AC");

                entity.ToTable("recipes");

                entity.Property(e => e.RecipeId).HasColumnName("recipeID");

                entity.Property(e => e.AddDate)
                    .HasColumnName("addDate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(CONVERT([date],getdate()))");

                entity.Property(e => e.IsApproved).HasColumnName("approved").HasDefaultValue(true);

                entity.Property(e => e.ImgUrl)
                    .HasColumnName("imgUrl")
                    .HasMaxLength(2083)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.UserId)
                    .HasColumnName("userID")
                    .HasDefaultValueSql("((0))");

            });

            modelBuilder.Entity<UserFavouriteRecipes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__userFavo__3213E83F773C3A58");

                entity.ToTable("userFavouriteRecipes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RecipeId).HasColumnName("recipeID");

                entity.Property(e => e.UserId).HasColumnName("userID");

            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__users__CB9A1CDF9744EEA3");

                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
