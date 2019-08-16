using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestCodeFirst
{
    public class Order
    {
        public int Id { get; set; }

        //[Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        //public Customer Customer { get; set; }
    }
}
