using Controller;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class InvoiceView : Form, IInvoiceView
    {
        InvoiceController _controller;
        public InvoiceView()
        {
            InitializeComponent();

        }

        public string CustName
        {
            get { return this.lbName.Text; }
            set { this.lbName.Text = value; }
        }
        public string Adress
        {
            get { return this.lbAddress.Text; }
            set { this.lbAddress.Text = value; }
        }
        public string Status
        {
            get
            {
                return this.lbStatus.Text;
            }
            set
            {
                this.lbStatus.Text = value;
            }
        }
        public string CustomerType
        {
            get { return this.lbCustomerType.Text; }
            set { this.lbCustomerType.Text = value; }
        }


        public void AddInvoicesToGrid(List<Invoice> invoices)
        {
            dgbInvoices.ColumnCount = 4;
            dgbInvoices.Columns[0].Name = "No. Factura";
            dgbInvoices.Columns[1].Name = "TotalIbis";
            dgbInvoices.Columns[2].Name = "Subtotal";
            dgbInvoices.Columns[3].Name = "Total";

            foreach (var invoice in invoices)
            {
                dgbInvoices.Rows.Add(invoice.Id, invoice.TotalItbis, invoice.SubTotal, invoice.Total);
            }
        }

        public void SetController(InvoiceController controller)
        {
            _controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {

        }

        private void dgbInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            ShowInvoiceDetail();
        }

        public void ShowInvoiceDetail()
        {
            int id = Convert.ToInt32(dgbInvoices.Rows[dgbInvoices.CurrentRow.Index].Cells[0].Value);
            InvoiceDetailView invoiceDetailView = new InvoiceDetailView();
            var invoice = _controller.GetInvoiceById(id);
            InvoiceDetailController invoiceDetailController = new InvoiceDetailController(invoiceDetailView, invoice);
            invoiceDetailController.LoadGridView();
            invoiceDetailView.ShowDialog();
        }
    }
}
