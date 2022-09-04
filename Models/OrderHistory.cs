using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BetDevTestClassLibrary.Model
{
    public partial class OrderHistory
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string UserEmail { get; set; }
        public int CartId { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual Cart Cart { get; set; }
    }

}
