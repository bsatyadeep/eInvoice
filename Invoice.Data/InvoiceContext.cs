using System.Data.Entity;
using Invoice.Entity;
using Invoice.Entity.Mappers;

namespace Invoice.Data
{
    public class InvoiceContext : DbContext
    {
        public InvoiceContext() : base("eInvoiceConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<InvoiceContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<InvoiceContext, InvoiceContextMigrationConfiguration>());
        }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Invoices>      Invoices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new InvoiceDetailMapper());
            modelBuilder.Configurations.Add(new InvoiceMapper());
            base.OnModelCreating(modelBuilder);
        }
    }
}
