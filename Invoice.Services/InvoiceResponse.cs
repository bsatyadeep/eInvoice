using System.Collections.Generic;
using System.Runtime.Serialization;
using Invoice.Common.Library;
using Invoice.Entity;

namespace Invoice.Services
{
    [DataContract]
    public class InvoiceResponse:ResponseBase
    {
        [DataMember]
        public List<Invoices> DetailData { get; set; }
        [DataMember]
        public List<InvoiceDetail> DataCollection { get; set; }
    }
}