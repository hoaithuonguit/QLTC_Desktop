using QLTC_Desktop.Model;
using QLTC_Desktop.ResponsityController;
using QLTC_Desktop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC_Desktop.Controllers
{
    public class MainController
    {
        private WalletController control;
        public void OpenAddWallet()
        {
            AddWallet wallet = new AddWallet();
            wallet.Show();
        }
        public void OpenListWallet()
        {
            ListWallet l = new ListWallet();
            l.Show();
        }
        public void AddNewMoney()
        {
            AddMoney a = new AddMoney();
            a.Show();
        }
        public void AddNewSpending()
        {
            AddSpending a = new AddSpending();
            a.Show();
        }
        public void OpenLookUp()
        {
            LookUp l = new LookUp();
            l.Show();
        }
        public void OpenInfo()
        {
            Info i = new Info();
            i.Show();
        }
        public List<WalletShowModel> getWallet()
        {
            control = new WalletController();
            return control.getAllWallet();
        }
        public int getSum()
        {
            control = new WalletController();
            return control.SumMoney();
        }
    }
}
