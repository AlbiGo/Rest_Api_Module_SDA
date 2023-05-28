using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class LiberLexues : ModeliBaze
    {
        [ForeignKey("Lexues")]
        [Required]
        public int LexuesID { get; set; }
        public Lexues Lexues { get; set; }

        [ForeignKey("Liber")]
        [Required]
        public int LiberID { get; set; }
        public Liber LIber { get; set; }

        public bool EshteAktiv { get; set; }
    }
}
