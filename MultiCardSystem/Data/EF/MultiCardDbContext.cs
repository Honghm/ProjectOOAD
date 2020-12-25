
using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Data.EF
{
   public class MultiCardDbContext : DbContext
    {
        public MultiCardDbContext() : base("name=con") { }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Card> Cards { get; set; }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Account>().HasKey(x => x.ID);
            modelBuilder.Entity<Account>().Property(x => x.UserName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Account>().Property(x => x.PassWord).IsRequired().HasMaxLength(50);        
            modelBuilder.Entity<Account>().Property(x => x.Money).IsRequired();
            modelBuilder.Entity<Account>().HasRequired(a => a.Card).WithRequiredPrincipal(c => c.Account);
            modelBuilder.Entity<Account>().HasRequired(c => c.Customer).WithRequiredPrincipal(a => a.Account);



            modelBuilder.Entity<Card>().ToTable("Card");
            modelBuilder.Entity<Card>().HasKey(x => x.IDCard);
            modelBuilder.Entity<Card>().Property(x => x.DateCreated).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Card>().Property(x => x.PINCode).IsRequired().HasMaxLength(6);
            modelBuilder.Entity<Card>().HasRequired(c =>c.Customer ).WithRequiredPrincipal(a=>a.Card);


            modelBuilder.Entity<Bill>().ToTable("Bill");
            modelBuilder.Entity<Bill>().HasKey(x => x.IDBill);
            modelBuilder.Entity<Bill>().Property(x => x.ServiceName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Bill>().Property(x => x.DateCreated).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Bill>().Property(x => x.ServiceMachine).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Bill>().Property(x => x.TotalMoney).IsRequired();
            // modelBuilder.Entity<Bill>().HasRequired<Account>(b => b.CurrentAccount).WithMany(a => a.Bills).HasForeignKey<int>(b => b.CurrentAccountID);
            modelBuilder.Entity<Bill>()
            .HasRequired(b=>b.CurrentAccount)            //hasone
            .WithMany(a => a.Bills)
            .HasForeignKey(b => b.CurrentAccountID);

            modelBuilder.Entity<Bill>()
            .HasRequired(b => b.CurrentSupplier)         //hasone
            .WithMany(a => a.Bills)
            .HasForeignKey(b => b.CurrentSupplierID);

            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>().HasKey(x => x.IDCustomer);
            modelBuilder.Entity<Customer>().Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(x => x.LastName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(x => x.Dob).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(x => x.CMND).IsRequired().HasMaxLength(11);
            modelBuilder.Entity<Customer>().Property(x => x.PhoneNumber).HasMaxLength(10);
            modelBuilder.Entity<Customer>().Property(x => x.Address).HasMaxLength(100);

            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Supplier>().HasKey(x => x.IDSupplier);

            modelBuilder.Entity<Report>().ToTable("Report");
            modelBuilder.Entity<Report>().HasKey(x => x.ReportID);
            modelBuilder.Entity<Report>().Property(x => x.DateReport).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Report>().Property(x => x.Note).IsRequired().HasMaxLength(200);

            modelBuilder.Entity<Report>()
            .HasRequired(b => b.CurrentCustomer)         //hasone
            .WithMany(a => a.Reports)
            .HasForeignKey(b => b.CustomerID);

            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<Role>().HasKey(x => x.RoleId);          
            modelBuilder.Entity<Role>().HasMany(x => x.Accounts).WithMany(x => x.Roles).Map(m => m.ToTable("AccountRoles").MapLeftKey("RoleId").MapRightKey("ID"));
        }

    }
}
