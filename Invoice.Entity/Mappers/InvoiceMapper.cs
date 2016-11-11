using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Invoice.Entity.Mappers
{
    public class InvoiceMapper: EntityTypeConfiguration<Invoices>
    {
        public InvoiceMapper()
        {
            this.ToTable("Invoices");
            this.HasKey(inv => inv.InvoiceId);
            this.Property(inv => inv.InvoiceId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(inv => inv.InvoiceId).IsRequired();

            this.Property(inv => inv.TotalInvoiceAmount).IsRequired();
            this.Property(inv => inv.TotalTaxableAmount).IsRequired();   
        }        
    }
}
