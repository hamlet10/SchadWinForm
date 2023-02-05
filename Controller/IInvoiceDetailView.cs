using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface IInvoiceDetailView
    {
        void SetController(InvoiceDetailController controller);
        void AddItemsToGrid(List<InvoiceDetail> invoiceItems);
        void AddNewInvoiceDetail();
        string CustomerId { get; set; }
        string Qty { get; set; }
        string Price { get; set; }
        string TotalItbis { get; set; }
        string SubTotal { get; set; }
        string Total { get; set; }
    }
}

