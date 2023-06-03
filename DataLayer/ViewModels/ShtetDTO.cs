using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class ShtetDTO
    {
        public Name name { get; set; }
        public string status { get; set; }
    }
    public class Name
    {
        public string official { get; set; }
    }
}
