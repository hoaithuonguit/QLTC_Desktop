using QLTC_Desktop.ResponsityController;
using QLTC_Desktop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC_Desktop.Controllers
{
    public class SpendingController
    {
        private ActionController action;
        private WalletController wallet;
        private HistoryAction h_action;
        public List<String> getAction()
        {
            action = new ActionController();
            return action.getAllAction();
        }
        public List<String> getWallet()
        {
            wallet = new WalletController();
            return wallet.getWalletName();
        }
        public void Back()
        {
            Main m = new Main();
            m.Show();
        }
        public String addNewSpending(String action_name, String wallet_name, int money, DateTime dateUse)
        {
            h_action = new HistoryAction();
            return h_action.AddNewHistory(action_name, wallet_name, money, dateUse);
        }
        public void OpenAddWallet()
        {
            AddWallet w = new AddWallet();
            w.Show(); 
        }
        public void OpenAddAction()
        {
            AddAction a = new AddAction();
            a.Show();
        }
    }
}
