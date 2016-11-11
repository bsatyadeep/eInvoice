using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Invoice.Entity
{
    [DataContract]
    public class Invoices
    {
        public Invoices()
        {
            this.InvoiceDetails = new List<InvoiceDetail>();
        }

        [DataMember]
        public int InvoiceId { get; set; }
        [DataMember]
        public DateTime InvoiceDate { get; set; }
        [DataMember]    
        public double TotalTaxableAmount { get; set; }
        [DataMember]
        public double TotalInvoiceAmount { get; set; }
        [DataMember]
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}
