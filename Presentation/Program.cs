using Controller;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.``
        /// </summary>
        [STAThread]
        static void Main()
        {
            Customers selectedCustomer = new Customers();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Form1 customerView = new Form1();
            CustomersController controller = new CustomersController(customerView, selectedCustomer);
            controller.LoadGridView();
            customerView.ShowDialog();
        }
    }
}
