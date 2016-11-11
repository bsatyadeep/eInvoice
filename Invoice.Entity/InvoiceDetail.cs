using System;
using System.Runtime.Serialization;

namespace Invoice.Entity
{
    [DataContract]
    public class InvoiceDetail
    {
        [DataMember]
        public int InvoiceNo { get; set; }
        [DataMember]
        public InvoiceType Type { get; set; }
        [DataMember]
        public string ClientNumber { get; set; }
        [DataMember]
        public DateTime InvoiceDate { get; set; }
        [DataMember]
        public double InvoiceAmount { get; set; }
    }
}