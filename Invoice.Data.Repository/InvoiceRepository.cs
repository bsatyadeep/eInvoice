using System.Collections.Generic;
using System.Linq;
using Invoice.BusinessLayer;
using Invoice.Entity;

namespace Invoice.Data.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly InvoiceContext _ctx;

        public InvoiceRepository()
        {
            if (_ctx == null)
            {
                _ctx = new InvoiceContext();
            }
        }
        public InvoiceRepository(InvoiceContext ctx)
        {
            _ctx = ctx;
        }

        #region IInvoiceRepository Members
        public List<Invoices> GetMonthlyInvoiceReport()
        {            
            List<InvoiceDetail> _invoiceList = _ctx.InvoiceDetails.ToList();
            InvoiceBusinessLayer _invoiceBusinessLayer = new InvoiceBusinessLayer();
            return _invoiceBusinessLayer.GetMonthlyInvoiceReportWithTax(_invoiceList);
        }
        public List<InvoiceDetail> GetAllInvoices()
        {
            return _ctx.InvoiceDetails.ToList();
        }
        #endregion
    }
}