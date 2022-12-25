using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        public int? ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public System.DateTime Date { get; set; }
        [Required]
        [ForeignKey("User")]
        public int CustomerId { get; set; }
        [Required]
        public string Status { get; set; }
        public User User { get; set; }
        public virtual List<Product> Products { get; set; }
        public virtual List<Equipment> Equipment { get; set; }
        public Order()
        {
            Products = new List<Product>();
            Equipment = new List<Equipment>();
        }
    }
}
