using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Controller
{
    public interface ICustomerView
    {
        void SetController(CustomersController controller);
        void AddNewUser();
        void AddCustomer(Customers customer);
        void AddCustomerToGrid(List<Customers> customers);
        void showInvices();

        string CustName { get; set; }
        string Adress { get; set; }
        bool Status { get; set; }
        int CustomerTypeId { get; set; }
    }
}
