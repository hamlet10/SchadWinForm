using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface IInvoiceView
    {
        void SetController(InvoiceController controller);
        void AddInvoicesToGrid(List<Invoice> invoices);
        void ShowInvoiceDetail();
        string CustName { get; set; }
        string Adress { get; set; }
        string Status { get; set; }
        string CustomerType { get; set; }
    }
}
