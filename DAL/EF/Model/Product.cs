using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
