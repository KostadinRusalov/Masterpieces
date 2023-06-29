using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Description
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string CreatorsName { get; set; }

        public string Descript { get; set; }
        [Required]
        public Material Material { get; set; }
    }
}
