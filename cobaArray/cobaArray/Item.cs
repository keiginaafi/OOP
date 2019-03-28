using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaArray
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; }

        [InverseProperty("Id")]
        [ForeignKey("Suppliers")]
        public int Supplier_Id { get; set; }
        public Supplier Suppliers { get; set; }
    }
}
