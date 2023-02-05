using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CustomersController
    {
        ICustomerView _view;
        Test_Invocie_Model _db;
        Customers _customer;
        public CustomersController(ICustomerView view, Customers customer)
        {
            _db = new Test_Invocie_Model();
            _view = view;
            view.SetController(this);
            _customer = customer;
        }

        public void LoadGridView()
        {
            var customerList = _db.Customers.ToList();
            _view.AddCustomerToGrid(customerList);
        }

        public void UpdateViewDetailValues(int? id)
        {
            if (id != null)
            {

                var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
                _view.CustName = customer.CustName;
                _view.Adress = customer.Adress;
                _view.Status = customer.Status;
                _view.CustomerTypeId = customer.CustomerTypeId;
            }
            else
            {
                List<CustomerType> customerTypes = _db.CustomerTypes.ToList();
                _view.CustName = "";
                _view.Adress = "";
                _view.Status = true;
                _view.CustomerTypeId = customerTypes.FirstOrDefault().Id;
            }

        }

        public void AddNewCustomer()
        {

            List<CustomerType> customerTypes = _db.CustomerTypes.ToList();
            _view.CustName = "";
            _view.Adress = "";
            _view.Status = true;
            _view.CustomerTypeId = customerTypes.FirstOrDefault().Id;
        }
        public bool AddRegister()
        {
            _customer = new Customers
            {
                CustName = _view.CustName,
                Adress = _view.Adress,
                Status = _view.Status,
                CustomerTypeId = _view.CustomerTypeId
            };
            _db.Customers.Add(_customer);

            var saved = _db.SaveChanges() > 0;
            return saved;
        }

        public Customers GetCustomer (int id)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == id);
            return customer;
        }
    }
}
