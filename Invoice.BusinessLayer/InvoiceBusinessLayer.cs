using System.Collections.Generic;
using System.Linq;
using Invoice.Entity;

namespace Invoice.BusinessLayer
{
    public class InvoiceBusinessLayer
    {        
        public List<Invoices> GetMonthlyInvoiceReportWithTax(List<InvoiceDetail> invoiceses)
        {
            List<Invoices> _invoiceReports = new List<Invoices>();
            TaxRate _taxRate = new TaxRate();
            if (invoiceses != null)
            {
                var _invoiceList =  invoiceses.GroupBy(inv => inv.InvoiceDate.ToString("MM-yyyy"))
                        .Select(group => group.AsQueryable());

                foreach (var invoice in invoiceses)
                {
                   
                    string _invoiceReportDate = invoice.InvoiceDate.ToString("MM-yyyy");                   
                    switch (invoice.Type)
                    {
                        case InvoiceType.Domestic:
                            //invoice.TotalTaxableAmount = invoice.InvoiceAmount*_taxRate.ST/100 +
                            //                             invoice.InvoiceAmount*_taxRate.EC/100;
                            //invoice.TotalInvoiceAmount = invoice.InvoiceAmount + invoice.TotalTaxableAmount;
                            break;
                        case InvoiceType.International:
                            //invoice.TotalTaxableAmount = invoice.InvoiceAmount * _taxRate.FRT / 100;
                            //invoice.TotalInvoiceAmount = invoice.InvoiceAmount + invoice.TotalTaxableAmount;
                            break;
                    }
                }                
            }
            return null;
        }
    }
}
