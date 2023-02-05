using System.Collections.Generic;

namespace Models
{
    public class CustomerType
    {
        public CustomerType()
        {
            Customers = new HashSet<Customers>();
        }

        public int Id { get; set; }

        public string Description { get; set; }


        public virtual ICollection<Customers> Customers { get; set; }
    }
}