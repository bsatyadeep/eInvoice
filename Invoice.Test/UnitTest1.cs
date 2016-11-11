using System.Collections.Generic;
using System.Linq;
using Invoice.BusinessLayer;
using Invoice.Data;
using Invoice.Data.Repository;
using Invoice.Entity;
using Invoice.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Invoice.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRepository()
        {
            IInvoiceRepository _invoiceRepository = new InvoiceRepository(new InvoiceContext());
            List<InvoiceDetail> _list = _invoiceRepository.GetAllInvoices().ToList();

            InvoiceBusinessLayer _businessLayer = new InvoiceBusinessLayer();
            List<Invoices> _list1 = _businessLayer.GetMonthlyInvoiceReportWithTax(_list);
        }
        [TestMethod]
        public void TestService()
        {
            InvoiceServices _services = new InvoiceServices();
            InvoiceResponse _response = _services.GetAllInvoices();
        }
    }
}
