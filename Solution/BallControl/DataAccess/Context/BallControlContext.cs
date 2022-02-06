using Core.Models.Basic;
using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataAccess.Context
{
    public partial class BallControlContext : DbContext
    {
        public BallControlContext()
        {
        }

        public BallControlContext(DbContextOptions<BallControlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Fixture> Fixtures { get; set; }
        public virtual DbSet<PredictionPrerequisite> PredictionPrerequisites { get; set; }
        public virtual DbSet<PredictionStatus> PredictionStatuses { get; set; }
        public virtual DbSet<Prediction> Predictions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<StatisticType> StatisticTypes { get; set; }
        public virtual DbSet<UserBet> UserBets { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserSavedPrediction> UserSavedPredictions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=STELMASHCHUK-DE;Database=BallControl;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>(entity =>
            {
                entity.Property(e => e.LogoUrl)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Competitions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competitions_Countries");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlagUrl)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fixture>(entity =>
            {
                entity.Property(e => e.UtcDate).HasColumnType("datetime2(2)");

                entity.HasOne(d => d.Competition)
                    .WithMany(p => p.Fixtures)
                    .HasForeignKey(d => d.CompetitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fixtures_Competitions");
            });

            modelBuilder.Entity<PredictionPrerequisite>(entity =>
            {
                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.Prediction)
                    .WithMany(p => p.PredictionPrerequisites)
                    .HasForeignKey(d => d.PredictionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PredictionPrerequisites_Predictions");

                entity.HasOne(d => d.StatisticType)
                    .WithMany(p => p.PredictionPrerequisites)
                    .HasForeignKey(d => d.StatisticTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PredictionPrerequisites_StatisticTypes");
            });

            modelBuilder.Entity<PredictionStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Prediction>(entity =>
            {
                entity.Property(e => e.DisplayText)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Fixture)
                    .WithMany(p => p.Predictions)
                    .HasForeignKey(d => d.FixtureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Predictions_Fixtures");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Predictions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Predictions_PredictionStatuses");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StatisticType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserBet>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CreatedDateUtc).HasColumnType("datetime2(2)");

                entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Prediction)
                    .WithMany(p => p.UserBets)
                    .HasForeignKey(d => d.PredictionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBets_Predictions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserBets)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBets_Users");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId })
                    .HasName("PK_UserRoles_1");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Users");
            });

            modelBuilder.Entity<UserSavedPrediction>(entity =>
            {
                entity.HasOne(d => d.Prediction)
                    .WithMany(p => p.UserSavedPredictions)
                    .HasForeignKey(d => d.PredictionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSavedPredictions_Predictions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSavedPredictions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSavedPredictions_Users");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
