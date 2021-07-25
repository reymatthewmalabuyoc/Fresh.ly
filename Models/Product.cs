using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Fresh.ly.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stock { get; set; }
        public int MyProperty { get; set; }
        public virtual Supplier Supplier { get; set; }
        public int? SupplierID { get; set; }

    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
    }
}
