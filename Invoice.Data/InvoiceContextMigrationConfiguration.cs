using System.Data.Entity.Migrations;

namespace Invoice.Data
{
    class InvoiceContextMigrationConfiguration : DbMigrationsConfiguration<InvoiceContext>
    {
        public InvoiceContextMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        #if DEBUG
        protected override void Seed(InvoiceContext context)
        {
            new InvoiceDataSeeder(context).Seed();
        }
        #endif
    }
}
