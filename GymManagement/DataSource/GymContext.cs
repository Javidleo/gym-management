using GymManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DataSource
{
    public class GymContext : DbContext
    {
        public GymContext() : base("gymConnection")
        {
        }

        public DbSet<Admin> Admins {get;set;}
        public DbSet<AdminActivity> Activity {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<InstallmentOption> InstallmentOptions {get;set;}
        public DbSet<Transaction> Transactions { get;set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // define keys and rules
            modelBuilder.Entity<User>().HasKey<int>(i => i.Id);
            modelBuilder.Entity<User>().Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Admin>().HasKey<int>(i => i.Id);
            modelBuilder.Entity<Admin>().Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<InstallmentOption>().HasKey<int>(i => i.Id);
            modelBuilder.Entity<InstallmentOption>().Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Transaction>().HasKey<int>(i => i.Id);
            modelBuilder.Entity<Transaction>().Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<AdminActivity>().HasKey<int>(i => i.Id);
            modelBuilder.Entity<AdminActivity>().Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<User>()
                .HasRequired(i => i.Admin)
                .WithMany(i => i.Users)
                .HasForeignKey(i => i.AdminId).WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(i => i.PeriodOption)
                .WithMany(i => i.PeriodUsers)
                .HasForeignKey(i => i.PeriodId).WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(i => i.Option)
                .WithMany(i => i.OptionUser)
                .HasForeignKey(i => i.OptionId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasRequired(i => i.User)
                .WithMany(i => i.Transactions)
                .HasForeignKey(i => i.UserId).WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasRequired(i => i.Admin)
                .WithMany(i => i.Transactions)
                .HasForeignKey(i => i.AdminId).WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminActivity>()
                .HasRequired(i => i.Admin)
                .WithMany(i => i.Activity)
                .HasForeignKey(i => i.AdminId).WillCascadeOnDelete(false);

        }
    }
}
