using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Invoice.Entity.Mappers
{
    public class InvoiceDetailMapper : EntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailMapper()
        {
            this.ToTable("InvoiceDetails");
            this.HasKey(inv => inv.InvoiceNo);
            this.Property(inv => inv.InvoiceNo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(inv => inv.InvoiceNo).IsRequired();

            this.Property(inv => inv.ClientNumber).IsRequired();
            this.Property(inv => inv.ClientNumber).HasMaxLength(4);

            this.Property(inv => inv.InvoiceDate).IsRequired();
            this.Property(inv => inv.InvoiceAmount).IsRequired();
        }
    }
}
