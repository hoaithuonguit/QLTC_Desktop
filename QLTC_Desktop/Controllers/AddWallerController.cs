using QLTC_Desktop.Responsity;
using QLTC_Desktop.ResponsityController;
using QLTC_Desktop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC_Desktop.Controllers
{
   public class AddWallerController
    {
        private WalletController control;
        public void BackToMain()
        {
            Main m = new Main();
            m.Show();
        }
        public String CheckDataInput(String name, int money)
        {
            if (!name.Equals("") && money > 0)
            {
                return "Success";
            }
            else
            {
                String mess = "";
                int k = 0;
                if (name.Equals(""))
                {
                    mess += "Tên không được để trống";
                    k = 1;
                }
                if (money <= 0)
                {
                    if (k == 0)
                        mess += " Số tiền không hợp lệ.";
                    else mess += "và số tiền không hợp lệ.";
                }
                return mess;
            }
        }

        public String Add(String name, int money)
        {
            control = new WalletController();
            return control.insertWallet(name, money);
        }
    }
}
