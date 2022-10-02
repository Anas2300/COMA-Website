using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MusicianApp.Models
{
    public partial class MusiciansContext : DbContext
    {
        public MusiciansContext()
        {
        }

        public MusiciansContext(DbContextOptions<MusiciansContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<MusicAssociation> MusicAssociation { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonInstrument> PersonInstrument { get; set; }
        public virtual DbSet<PersonMusicAssociation> PersonMusicAssociation { get; set; }
        public virtual DbSet<Phone> Phone { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=OntarioMusicians;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Instrument>(entity =>
            {
                entity.ToTable("instrument");

                entity.Property(e => e.InstrumentId)
                    .HasColumnName("instrumentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InstrumentName)
                    .IsRequired()
                    .HasColumnName("instrumentName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MusicAssociation>(entity =>
            {
                entity.ToTable("musicAssociation");

                entity.Property(e => e.MusicAssociationId)
                    .HasColumnName("musicAssociationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasColumnName("genre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MusicAssociationName)
                    .IsRequired()
                    .HasColumnName("musicAssociationName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("person");

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.AssociationDate)
                    .HasColumnName("associationDate")
                    .HasColumnType("date");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BalanceDue).HasColumnName("balanceDue");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("firstName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("lastName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Request).HasColumnName("request");

                entity.Property(e => e.StatusId).HasColumnName("statusId");
            });

            modelBuilder.Entity<PersonInstrument>(entity =>
            {
                entity.ToTable("personInstrument");

                entity.Property(e => e.PersonInstrumentId)
                    .HasColumnName("personInstrumentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.InstrumentId).HasColumnName("instrumentId");

                entity.Property(e => e.PersonId).HasColumnName("personID");
            });

            modelBuilder.Entity<PersonMusicAssociation>(entity =>
            {
                entity.ToTable("personMusicAssociation");

                entity.Property(e => e.PersonMusicAssociationId)
                    .HasColumnName("personMusicAssociationId")
                    .ValueGeneratedNever();

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasColumnName("memberName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MusicAssociationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.HasKey(e => e.PhoneNumber);

                entity.ToTable("phone");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.PhoneType)
                    .IsRequired()
                    .HasColumnName("phoneType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.ToTable("phoneType");

                entity.Property(e => e.PhoneTypeId)
                    .HasColumnName("phoneTypeId")
                    .ValueGeneratedNever();

                entity.Property(e => e.PhoneType1)
                    .IsRequired()
                    .HasColumnName("phoneType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusId")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusType)
                    .IsRequired()
                    .HasColumnName("statusType")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
