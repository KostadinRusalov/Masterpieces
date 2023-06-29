using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class ProductOrder
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public Order Order { get; set; }
        [Key]
        public Masterpiece Masterpiece { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
