using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FinalFantasyAPI.Context
{
    public partial class FF_DbContext : DbContext
    {
        public FF_DbContext()
        {
        }

        public FF_DbContext(DbContextOptions<FF_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Armor> Armor { get; set; }
        public virtual DbSet<ArmorType> ArmorType { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobArmor> JobArmor { get; set; }
        public virtual DbSet<JobWeapon> JobWeapon { get; set; }
        public virtual DbSet<Monster> Monster { get; set; }
        public virtual DbSet<Weapon> Weapon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Armor>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Absorb).HasColumnName("absorb");

                entity.Property(e => e.Evade).HasColumnName("evade");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.TypeId).HasColumnName("typeId");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Armor)
                    .HasForeignKey(d => d.TypeId);
            });

            modelBuilder.Entity<ArmorType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<JobArmor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ArmorId).HasColumnName("armorId");

                entity.Property(e => e.JobId).HasColumnName("jobId");

                entity.HasOne(d => d.Armor)
                    .WithMany()
                    .HasForeignKey(d => d.ArmorId);

                entity.HasOne(d => d.Job)
                    .WithMany()
                    .HasForeignKey(d => d.JobId);
            });

            modelBuilder.Entity<JobWeapon>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.JobId).HasColumnName("jobId");

                entity.Property(e => e.WeaponId).HasColumnName("weaponId");

                entity.HasOne(d => d.Job)
                    .WithMany()
                    .HasForeignKey(d => d.JobId);

                entity.HasOne(d => d.Weapon)
                    .WithMany()
                    .HasForeignKey(d => d.WeaponId);
            });

            modelBuilder.Entity<Monster>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ap).HasColumnName("ap");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Exp).HasColumnName("exp");

                entity.Property(e => e.Gold).HasColumnName("gold");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.IsBoss).HasColumnName("isBoss");

                entity.Property(e => e.JpName).HasColumnName("jpName");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Resist).HasColumnName("resist");

                entity.Property(e => e.Spells).HasColumnName("spells");

                entity.Property(e => e.Weakness).HasColumnName("weakness");
            });

            modelBuilder.Entity<Weapon>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Damage).HasColumnName("damage");

                entity.Property(e => e.Hit).HasColumnName("hit");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
