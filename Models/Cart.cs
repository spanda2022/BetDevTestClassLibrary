using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BetDevTestClassLibrary.Model
{
    public partial class Cart
    {
       
        public Cart()
        {
            this.CartProducts = new List<CartProduct>();
            this.OrderHistories = new List<OrderHistory>();
        }

        public int Id { get; set; }
        public string CardNo { get; set; }
        public string UserEmail { get; set; }
        public decimal TotalCartPrice { get; set; }
        public Nullable<bool> IsActive { get; set; }

       
        public virtual List<CartProduct> CartProducts { get; set; }
       
        public virtual List<OrderHistory> OrderHistories { get; set; }
    }


}
