using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class InvoiceDetailController
    {
        IInvoiceDetailView _view;
        Test_Invocie_Model _db;
        Invoice _invoice;
        public InvoiceDetailController(IInvoiceDetailView view, Invoice invoice)
        {
            _db = new Test_Invocie_Model();
            _view = view;
            _invoice = invoice;
            _view.SetController(this);

        }

        public void LoadGridView()
        {
            var invoiceDetails = _invoice.InvoiceDetails.ToList();
            _view.AddItemsToGrid(invoiceDetails);
            UpdateViewDetailValues(invoiceDetails.FirstOrDefault().Id);
        }
        public void UpdateViewDetailValues(int? id)
        {
            if(id != null)
            {
                var invoiceDetail = _db.InvoiceDetail.FirstOrDefault(x => x.Id == id);
                _view.CustomerId = invoiceDetail.CustomerId.ToString();
                _view.Qty = invoiceDetail.Qty.ToString();
                _view.Price = invoiceDetail.Price.ToString();
                _view.TotalItbis = invoiceDetail.TotalItbis.ToString();
                _view.SubTotal = invoiceDetail.SubTotal.ToString();
                _view.Total = invoiceDetail.Total.ToString();

            }
        }

        public void AddNewItem()
        {
            _view.Qty = "";
            _view.Price = "";
            _view.TotalItbis = "";
            _view.SubTotal = "";
            _view.Total = "";
        }
        public bool AddRegister()
        {
             InvoiceDetail invoiceDetail = new InvoiceDetail
            {
                CustomerId = _invoice.Id,
                Qty = int.Parse(_view.Qty),
                Price = decimal.Parse(_view.Price),
                TotalItbis = decimal.Parse(_view.TotalItbis),
                SubTotal = decimal.Parse(_view.SubTotal),
                Total = decimal.Parse(_view.Total)
            };

            _db.InvoiceDetail.Add(invoiceDetail);
            var saved = _db.SaveChanges() > 0;
            return saved;
        }
    }
}
