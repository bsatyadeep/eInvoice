using System.Data.Services;
using System.Data.Services.Common;
using System.ServiceModel;

namespace Invoice.Services
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class InvoiceDataService : DataService<InvoiceServices>
    {        
        public static void InitializeService(DataServiceConfiguration config)
        {            
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }
    }
}
