using GymManagement.Model;
using System;
using System.Collections.Generic;
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
            modelBuilder.Entity<User>().HasKey<int>(i => i.Id);

            modelBuilder.Entity<User>()
                .HasRequired(i => i.Admin)
                .WithMany(i => i.Users)
                .HasForeignKey(i => i.AdminId).WillCascadeOnDelete(false);

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
