using System.Collections.Generic;
using System.ServiceModel;
using Invoice.Entity;

namespace Invoice.Data.Repository
{    
    public interface IInvoiceRepository
    {        
        List<InvoiceDetail> GetAllInvoices();
        List<Invoices> GetMonthlyInvoiceReport();
    }
}