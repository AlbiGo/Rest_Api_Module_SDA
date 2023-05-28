using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Liber : ModeliBaze
    {
        [Required]
        public string Titull { get; set; }

        //Kategori Lidhje
        [ForeignKey("Kategori")]
        [Required]
        public int KategoriID { get; set; }
        public Kategori Kategori { get; set; }
        
        public string Autori { get; set; }
        public DateTime? DataRegjistrimit { get; set; }
        public string Status { get; set; }
    }
}
