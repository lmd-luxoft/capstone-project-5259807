using HomeAccounting.BusinessLogic.EF.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinessLogic.EF.AppLogic
{
    public class DomainContext : DbContext
    {
        private const string _connectionString = "Server=STAND;Database=HomeAccounting;Integrated Security=True;";

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<Cash> Cashes { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyChange> PropertyChanges { get; set; }

        public DbSet<Deposit> Deposit { get; set; }

        public DomainContext(DbContextOptions<DomainContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Bank>();
            modelBuilder.Entity<Deposit>().ToTable("Deposites");
            modelBuilder.Entity<Operation>().HasMany(x => x.Account);
            modelBuilder.Entity<Property>().ToTable("Properties").HasMany(x => x.PropertyChange);
            modelBuilder.Entity<PropertyChange>();
            modelBuilder.Entity<Cash>().ToTable("Cashes");
        }
    }
}
