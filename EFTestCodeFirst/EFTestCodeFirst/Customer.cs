
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestCodeFirst
{
    public class Customer
    {
        public int Id { get; set; }

        //[StringLength(50)]
        public string Firstname { get; set; }

        //[StringLength(50)]
        public string Lastname { get; set; }

        //[StringLength(50)]
        public string Email { get; set; }

        public string City { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Order> Orders { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}
