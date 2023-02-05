using System.Collections.Generic;

namespace Models
{
    public class Invoice
    {
        public Invoice()
        {
            this.InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalItbis { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public virtual Customers Customers { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }
}