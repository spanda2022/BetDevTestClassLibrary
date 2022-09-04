using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BetDevTestClassLibrary.Model
{
    public partial class Product
    {
       
        public Product()
        {
            this.CartProducts = new List<CartProduct>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]        
        [RegularExpression("[A-Za-z0-9]*", ErrorMessage = "Only Characters allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(1, Int32.MaxValue)]
        [RegularExpression("[0-9]*", ErrorMessage = "Only Numbers allowed")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Image path is required.")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Quantity can not be less then 1")]
        [RegularExpression("[0-9]*", ErrorMessage = "Only Numbers allowed")]
        public int Quantity { get; set; }
        public Nullable<bool> IsActive { get; set; }

        
        public virtual List<CartProduct> CartProducts { get; set; }
    }



}
