using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controller
{
    public class InvoiceController
    {
        Test_Invocie_Model _db;
        IInvoiceView _view;
        Customers _customer;
        public InvoiceController(IInvoiceView view, Customers customers)
        {
            _db = new Test_Invocie_Model();
            _view = view;
            _view.SetController(this);
            _customer = customers;
        }
        public void LoadGridView()
        {
            var invoices = _customer.Invoices.ToList();
            _view.AddInvoicesToGrid(invoices);
            UpdateViewDwetailVale(_customer.Id);
        }

        public void UpdateViewDwetailVale(int Id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == Id);
            _view.CustName = customer.CustName;
            _view.Adress = customer.Adress;
            _view.Status = customer.Status ? "Activo" : "Inactivo";
            _view.CustomerType = customer.CustomerTypes.Description.ToString();
        }

        public Invoice GetInvoiceById(int Id)
        {
            var invoice = _db.Invoice.FirstOrDefault(x => x.Id == Id);
            return invoice;
        }

    }
}
