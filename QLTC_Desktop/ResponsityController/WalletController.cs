using QLTC_Desktop.Model;
using QLTC_Desktop.Responsity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC_Desktop.ResponsityController
{
    public class WalletController
    {
      
        public String insertWallet(String name, int money)
        {
            using (var context = new QLTCDbEntities())
            {
                var k = (from a in context.Wallets
                          select a.ID).ToList();

                int id = k.Count();
                id++;
                var checkName = (from a in context.Wallets
                                 where a.Name.Equals(name)
                                 select a).ToList();
                if (checkName.Count() > 0)
                    return "1";
                else
                {
                    Wallet wallet = new Wallet()
                    {
                        ID = id,
                        Name = name,
                        FirstMoney = money,
                        Money = money
                    };
                    context.Wallets.Add(wallet);
                    context.Entry(wallet).State = EntityState.Added;
                    context.SaveChanges();
                    return "0";
                }
            }
        }
        public List<WalletShowModel> getAllWallet()
        {
            using (var context = new QLTCDbEntities())
            {
                var result = (from a in context.Wallets
                              select new WalletShowModel()
                              {
                                  ID = a.ID,
                                  Name = a.Name
                              }).ToList();
                return result;
            }
        }

        public int SumMoney()
        {
            using(var context = new QLTCDbEntities())
            {
                var ls = (from a in context.Wallets
                          select a.Money).ToList<int>();
                int result = 0;
                for (int i = 0; i< ls.Count(); i++)
                {
                    result += ls[i];
                }
                return result;
            }
        }
        public List<String> getWalletName()
        {
            using (var context = new QLTCDbEntities())
            {
                var result = (from a in context.Wallets
                              select a.Name).ToList();
                return result;
            }
        }

    }
}
