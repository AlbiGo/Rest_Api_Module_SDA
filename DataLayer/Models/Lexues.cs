using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Lexues : ModeliBaze
    {
        [Required]
        public string Emer { get; set; }
        [Required]
        public string Mbiemer { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime? DataFunditeLogimit { get; set; }
    }
}
