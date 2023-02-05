using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customers
    {
        public Customers()
        {
            this.Invoices = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public string CustName { get; set; }
        public string Adress { get; set; }
        public bool Status { get; set; }
        public int CustomerTypeId { get; set; }

        public virtual CustomerType CustomerTypes { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
