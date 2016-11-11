using System;
using System.Collections.Generic;
using System.Linq;
using Invoice.Entity;

namespace Invoice.Data
{
    public class InvoiceDataSeeder
    {
        private readonly InvoiceContext _ctx;

        public InvoiceDataSeeder(InvoiceContext ctx)
        {
            _ctx = ctx;
        }

        public void Seed()
        {
            if (_ctx.Invoices.Any())
            {
                return;
            }
            else
            {
                _ctx.InvoiceDetails.AddRange(InvoiceData);
            }
        }

        private static readonly IList<InvoiceDetail> InvoiceData = new List<InvoiceDetail>
        {
            new InvoiceDetail {InvoiceNo = 1, InvoiceDate = DateTime.Now, ClientNumber = "D123",InvoiceAmount = 1000,Type = InvoiceType.Domestic},
            new InvoiceDetail {InvoiceNo = 2, InvoiceDate = DateTime.Now, ClientNumber = "D111",InvoiceAmount = 3000,Type = InvoiceType.Domestic},
            new InvoiceDetail {InvoiceNo = 3, InvoiceDate = DateTime.Now, ClientNumber = "D123",InvoiceAmount = 1500,Type = InvoiceType.International},
            new InvoiceDetail {InvoiceNo = 4, InvoiceDate = DateTime.Now, ClientNumber = "I111",InvoiceAmount = 4000,Type = InvoiceType.International},
            new InvoiceDetail {InvoiceNo = 5, InvoiceDate = DateTime.Now, ClientNumber = "I314",InvoiceAmount = 3500,Type = InvoiceType.International},
            new InvoiceDetail {InvoiceNo = 6, InvoiceDate = DateTime.Now, ClientNumber = "D123",InvoiceAmount = 500,Type = InvoiceType.International},
            new InvoiceDetail {InvoiceNo = 7, InvoiceDate = DateTime.Now, ClientNumber = "I111",InvoiceAmount = 1000,Type = InvoiceType.International}
        };
        //1, D123, 05-01-2012, 1000
        //2, D111, 19-01-2012, 3000
        //3, D123, 21-01-2012, 1500
        //4, I111, 25-01-2012, 4000
        //5, I314, 25-01-2012, 3500
        //6, D123, 01-02-2012, 500
        //7, I111, 11-02-2012, 1000

    }
}
