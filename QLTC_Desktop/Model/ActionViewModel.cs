using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC_Desktop.Model
{
   public class ActionViewModel
    {
        public String NameWallet { get; set; }
        public String NameAction { get; set; }
        public int Money { get; set; }
        public DateTime DateUse { get; set; }
    }
}
