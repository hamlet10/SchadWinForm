using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Models;

namespace Presentation
{
    public partial class Form1 : Form, ICustomerView
    {
        CustomersController _controller;
        public Form1()
        {
            InitializeComponent();
        }



        public string CustName {
            get { return this.tbName.Text; }
            set { this.tbName.Text = value; }
        }
        public string Adress
        {
            get { return this.tbAddress.Text; }
            set { this.tbAddress.Text = value; }
        }
        public bool Status
        {
            get
            {
                if (this.rbActivo.Checked)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value == rbActivo.Checked)
                    this.rbActivo.Checked = true;
                else
                    this.rbInactivo.Checked = false;
            }
        }
        public int CustomerTypeId
        {
            get { return int.Parse(this.cbCustomerTypes.SelectedIndex.ToString()); }
            set { this.cbCustomerTypes.SelectedIndex = value; }
        }


        public void ClearFills()
        {
            throw new NotImplementedException();
        }

        public void SetController(CustomersController controller)
        {
            _controller = controller;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saved = _controller.AddRegister();
            if (saved)
                MessageBox.Show("Guaradado exitoso");
            _controller.LoadGridView();
        }

        public void AddCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        private void cbCustomerTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddNewUser()
        {
            _controller.AddNewCustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        public void AddCustomerToGrid(List<Customers> customers)
        {
            dgbCustomers.ColumnCount = 5;
            dgbCustomers.Columns[0].Name = "Codigo";
            dgbCustomers.Columns[1].Name = "Nombre";
            dgbCustomers.Columns[2].Name = "Dirección";
            dgbCustomers.Columns[3].Name = "Estatus";
            dgbCustomers.Columns[4].Name = "Tipo Cliente";

            foreach (var customer in customers)
            {
                dgbCustomers.Rows.Add(customer.Id, customer.CustName, customer.Adress, customer.Status, customer.CustomerTypeId);
            }
            _controller.UpdateViewDetailValues(3);
        }

        private void dgbCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgbCustomers.Rows[dgbCustomers.CurrentRow.Index].Cells[0].Value);
            
            _controller.UpdateViewDetailValues(id);
        }

        private void dgbCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgbCustomers.Rows[dgbCustomers.CurrentRow.Index].Cells[0].Value);

        }

        public void showInvices()
        {
            int id = Convert.ToInt32(dgbCustomers.Rows[dgbCustomers.CurrentRow.Index].Cells[0].Value);
            InvoiceView invoiceView = new InvoiceView();
            var customer = _controller.GetCustomer(id);
            InvoiceController invoiceController = new InvoiceController(invoiceView, customer);
            invoiceController.LoadGridView();
            invoiceView.ShowDialog();
        }

        private void btnInvocieView_Click(object sender, EventArgs e)
        {
            showInvices();
        }
    }
}
