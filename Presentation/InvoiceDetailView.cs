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
    public partial class InvoiceDetailView : Form, IInvoiceDetailView
    {
        InvoiceDetailController _controller;
        public InvoiceDetailView()
        {
            InitializeComponent();
        }

        public string CustomerId { 
            get { return this.tbCustomerId.Text; }
            set { this.tbCustomerId.Text = value; }
        }
        public string Qty { 
            get { return this.tbQty.Text; }
            set { this.tbQty.Text = value; }
        }
        public string Price { 
            get { return this.TbPrice.Text; }
            set { this.TbPrice.Text = value; }
        }
        public string TotalItbis { 
            get { return this.tbTotalItbis.Text; }
            set { this.tbTotalItbis.Text = value; }
        }
        public string SubTotal { 
            get { return this.tbSubtotal.Text; }
            set { this.tbSubtotal.Text = value; }
        }
        public string Total { 
            get { return this.tbTotal.Text;  } 
            set { this.tbTotal.Text = value; }
        }

        public void AddItemsToGrid(List<InvoiceDetail> invoiceItems)
        {
            dgbInvoiceDetail.ColumnCount = 6;
            dgbInvoiceDetail.Columns[0].Name = "Item Id";
            dgbInvoiceDetail.Columns[1].Name = "Qty";
            dgbInvoiceDetail.Columns[2].Name = "Price";
            dgbInvoiceDetail.Columns[3].Name = "TotalItbis";
            dgbInvoiceDetail.Columns[4].Name = "Subtotal";
            dgbInvoiceDetail.Columns[5].Name = "Total";

            foreach (var item in invoiceItems)
            {
                dgbInvoiceDetail.Rows.Add(item.Id, item.Qty, item.Price, item.TotalItbis, item.SubTotal,
                    item.Total);
            }
        }

        public void AddNewInvoiceDetail()
        {
            _controller.AddNewItem();
        }

        public void SetController(InvoiceDetailController controller)
        {
            _controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewInvoiceDetail();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var saved = _controller.AddRegister();
            if (saved)
                MessageBox.Show("Guardado Exitoso");
            _controller.LoadGridView();
        }

        private void dgbInvoiceDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgbInvoiceDetail.Rows[dgbInvoiceDetail.CurrentRow.Index].Cells[0].Value);

            _controller.UpdateViewDetailValues(id);
        }
    }
}
