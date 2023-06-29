using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public abstract class Masterpiece
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Description Description { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
