using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ModeliBaze
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime DataKrijimit { get; set; }
        public DateTime? DataFshirjes { get; set; }
        public DateTime? DataPerditesimit { get; set; }
    }
}
