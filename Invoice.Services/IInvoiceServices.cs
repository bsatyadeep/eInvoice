using System.ServiceModel;

namespace Invoice.Services
{    
    [ServiceContract]
    public interface IInvoiceServices
    {        
        [OperationContract]
        InvoiceResponse GetAllInvoices();   
        [OperationContract]
        InvoiceResponse GetMonthlyInvoiceReport();
    }
}