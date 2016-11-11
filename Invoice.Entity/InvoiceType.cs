using System.Runtime.Serialization;
namespace Invoice.Entity
{
    [DataContract]
    public enum InvoiceType
    {
        Domestic = 0,
        International = 1
    }
}