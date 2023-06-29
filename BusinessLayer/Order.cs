using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public List<ProductOrder> ProductsQuantities { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public Status Status { get; set; }
    }
}
