using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int FarmerId { get; set; }
        [Required]
        public int RatingPoint { get; set; }
    }
}
