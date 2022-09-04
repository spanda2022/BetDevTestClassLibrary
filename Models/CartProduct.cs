using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BetDevTestClassLibrary.Model
{
    public partial class CartProduct
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }

        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }

    public class CartProductsView
    {
        public int Id { get; set; }
        public string CartNo { get; set; }

       
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public string ProductName { get; set; }
        // public Nullable<decimal> ProductPrice { get; set; }
     //   public decimal ProductPrice { get; set; }
        public decimal ProductPrice { get; set; }

        public string ProductImage { get; set; }

    }
}
