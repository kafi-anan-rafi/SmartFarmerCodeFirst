using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Model
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ServiceType { get; set; }
        public int ProviderId { get; set; }
        public System.DateTime Date { get; set; }
        public int Time { get; set; }
        public int Rate { get; set; }
        public int Bill { get; set; }
    }
}
