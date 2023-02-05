using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Test_Invocie_Model : DbContext
    {
        public Test_Invocie_Model()
            : base("name=Test_Invocie_Model")
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Customers)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerType>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.CustomerTypes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.TotalItbis)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .ToTable("dbo.Invoice");

            modelBuilder.Entity<Invoice>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Invoice)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<InvoiceDetail>()
            .ToTable("dbo.InvoiceDetail");

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.TotalItbis)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);
        }
    }
}
