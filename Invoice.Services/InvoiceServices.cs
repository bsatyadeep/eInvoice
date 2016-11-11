using System;
using System.Collections.Generic;
using Invoice.Common.Library;
using Invoice.Data;
using Invoice.Entity;

namespace Invoice.Services
{
    public class InvoiceServices:IInvoiceServices
    {
        private readonly InvoiceContext _ctx;
        public InvoiceServices()
        {
            if (_ctx == null)
            {
                _ctx = new InvoiceContext();
            }
        }
        public InvoiceServices(InvoiceContext ctx)
        {
            _ctx = ctx;
        }
        #region IInvoiceServices Members
        public InvoiceResponse GetAllInvoices()
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<InvoiceContext>());
            InvoiceResponse _Result = new InvoiceResponse();
            try
            {
                _Result.DataCollection = new List<InvoiceDetail>();
                foreach (InvoiceDetail item in _ctx.InvoiceDetails)
                {
                    _Result.DataCollection.Add(new InvoiceDetail{ InvoiceNo = item.InvoiceNo, ClientNumber = item.ClientNumber, InvoiceDate = item.InvoiceDate, InvoiceAmount = item.InvoiceAmount,Type = item.Type });
                }
                _Result.Status = OperationResult.Success;
            }
            catch (Exception ex)
            {
                _Result.ErrorMessage = ex.Message;
                _Result.FriendlyErrorMessage = "Error Getting All Invoices";
                _Result.Status = OperationResult.Exception;
            }
            return _Result;
        }
        public InvoiceResponse GetMonthlyInvoiceReport()
        {
            InvoiceResponse _Result = new InvoiceResponse();
            try
            {
                _Result.DetailData = new List<Invoices>();
                
                _Result.Status = OperationResult.Success;
            }
            catch (Exception ex)
            {
                _Result.ErrorMessage = ex.Message;
                _Result.FriendlyErrorMessage = "Error Getting Calculating Tax on Invoices";
                _Result.Status = OperationResult.Exception;
            }
            return _Result;
        }
        #endregion
    }
}