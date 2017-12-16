using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC_Desktop.Model
{
    public class WalletModel : BaseModel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int FirstMoney { get; set; }
        public int Money { get; set; }
    }
}
