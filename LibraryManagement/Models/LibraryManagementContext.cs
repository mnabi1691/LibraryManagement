using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryManagement.Models
{
    public partial class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext()
        {
        }

        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrator { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<LibraryUser> LibraryUser { get; set; }
        public virtual DbSet<LibraryUserRegistrationRequest> LibraryUserRegistrationRequest { get; set; }
        public virtual DbSet<Publisher> Publisher { get; set; }
        public virtual DbSet<Request> Request { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-CAG5V9G;Database=LibraryManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrator>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK__Administ__719FE488D6E37B9F");

                entity.Property(e => e.AccountStatus)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MobileNo).HasMaxLength(100);

                entity.Property(e => e.Nidno)
                    .HasColumnName("NIDNo")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportNo).HasMaxLength(100);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Upassword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(100);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.AuthId).HasColumnName("Auth_id");

                entity.Property(e => e.BookStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BookType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PubId).HasColumnName("Pub_id");

                entity.Property(e => e.Tittle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Auth)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.AuthId)
                    .HasConstraintName("auth_ID");

                entity.HasOne(d => d.Pub)
                    .WithMany(p => p.Book)
                    .HasForeignKey(d => d.PubId)
                    .HasConstraintName("PUB_ID");
            });

            modelBuilder.Entity<LibraryUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__LibraryU__1788CC4CAAE28753");

                entity.Property(e => e.AccountStatus).HasMaxLength(100);

                entity.Property(e => e.ActiveOn).HasColumnType("datetime");

                entity.Property(e => e.ApplicationId).HasColumnName("applicationID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MobileNo).HasMaxLength(100);

                entity.Property(e => e.Nidno)
                    .HasColumnName("NIDNo")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportNo).HasMaxLength(100);

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Upassword)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ApproverByNavigation)
                    .WithMany(p => p.LibraryUser)
                    .HasForeignKey(d => d.ApproverBy)
                    .HasConstraintName("FK__LibraryUs__Appro__01142BA1");
            });

            modelBuilder.Entity<LibraryUserRegistrationRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__LibraryU__1788CC4C1C0845BA");

                entity.Property(e => e.ActivationCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateOfBirth).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MobileNo).HasMaxLength(100);

                entity.Property(e => e.Nidno)
                    .HasColumnName("NIDNo")
                    .HasMaxLength(100);

                entity.Property(e => e.PassportNo).HasMaxLength(100);

                entity.Property(e => e.RequestTime).HasColumnType("datetime");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Upassword)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UserRequestStatus).HasMaxLength(30);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.PublisherId).HasColumnName("PublisherID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PuilisherName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(100);
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.RequestToken).HasMaxLength(100);

                entity.Property(e => e.Rstatus)
                    .IsRequired()
                    .HasColumnName("RStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.ApprovedBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Approved_By");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.BookId)
                    .HasConstraintName("FK_Book_Id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_Id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
