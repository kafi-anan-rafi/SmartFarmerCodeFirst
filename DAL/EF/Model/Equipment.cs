using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int SellerID { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }
        
    }
}
