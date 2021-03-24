using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MovieLibraryOO.DataModels
{
    public partial class movielensContext : DbContext
    {
        public movielensContext()
        {
        }

        public movielensContext(DbContextOptions<movielensContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<GenresMovie> GenresMovies { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=C:\\Users\\mcart\\OneDrive\\Documents\\WCTC\\MovieLibraryOO\\MovieLibraryOO\\SQLite\\movielens.sqlite3");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genres");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<GenresMovie>(entity =>
            {
                entity.ToTable("genres_movies");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.GenreId)
                    .HasColumnType("integer")
                    .HasColumnName("genre_id");

                entity.Property(e => e.MovieId)
                    .HasColumnType("integer")
                    .HasColumnName("movie_id");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movies");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ReleaseDate)
                    .HasColumnType("date")
                    .HasColumnName("release_date");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Occupation>(entity =>
            {
                entity.ToTable("occupations");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.ToTable("ratings");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.MovieId)
                    .HasColumnType("integer")
                    .HasColumnName("movie_id");

                entity.Property(e => e.RatedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("rated_at");

                entity.Property(e => e.Rating1)
                    .HasColumnType("integer")
                    .HasColumnName("rating");

                entity.Property(e => e.UserId)
                    .HasColumnType("integer")
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id)
                    .HasColumnType("integer")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Age)
                    .HasColumnType("integer")
                    .HasColumnName("age");

                entity.Property(e => e.Gender)
                    .HasColumnType("char(1)")
                    .HasColumnName("gender");

                entity.Property(e => e.OccupationId)
                    .HasColumnType("integer")
                    .HasColumnName("occupation_id");

                entity.Property(e => e.ZipCode)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("zip_code");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
