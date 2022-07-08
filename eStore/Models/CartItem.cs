using System.ComponentModel.DataAnnotations;

namespace eStore.Models
{
    public class CartItem
    {
        [Key]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}
