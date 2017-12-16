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
    public class HistoryAction
    {
        public String checkValidate(int money)
        {
            if (money <= 0) return "Số tiền không hợp lệ.";
            return "Success";
        }
        public String AddNewHistory(String action, 
                                    String wallet,
                                    int money,
                                    DateTime dateUse)
        {
            using (var context = new QLTCDbEntities())

                if (checkValidate(money).Equals("Success"))
                {
                    int i_action = (from a in context.ActionNames
                                    where a.ActionName1.Equals(action)
                                    select a.ID).FirstOrDefault();
                    int i_wallet = (from a in context.Wallets
                                    where a.Name.Equals(wallet)
                                    select a.ID).FirstOrDefault();
                    var i = (from a in context.MemoryActions
                             select a.ID).ToList();
                    int id = i.Count();

                    MemoryAction m = new MemoryAction()
                    {
                        ID = id,
                        ID_action = i_action,
                        ID_wallet = i_wallet,
                        Money = money,
                        DateUse = dateUse
                    };

                    context.MemoryActions.Add(m);
                    context.Entry(m).State = EntityState.Added;
                    context.SaveChanges();
                    return "Success";
                }
                else return checkValidate(money);
            }
        public List<ActionViewModel> search(DateTime start, DateTime end)
        {
            using(var context = new QLTCDbEntities())
            {
                var result = (from w in context.Wallets
                              from a in context.ActionNames
                              from m in context.MemoryActions
                              where
                                   a.ID.Equals(m.ID_action)
                                   && w.ID.Equals(m.ID_wallet)
                                   && m.DateUse >= start
                                   && m.DateUse <= end
                              select new ActionViewModel()
                              {
                                  NameWallet = w.Name,
                                  NameAction = a.ActionName1,
                                  Money = m.Money,
                                  DateUse = m.DateUse
                              }).ToList();
                return result;
            }
        }
        public List<ActionViewModel> GetAll()
        {
            using (var context = new QLTCDbEntities())
            {
                var result = (from w in context.Wallets
                              from a in context.ActionNames
                              from m in context.MemoryActions
                              where
                                   a.ID.Equals(m.ID_action)
                                   && w.ID.Equals(m.ID_wallet)
                              select new ActionViewModel()
                              {
                                  NameWallet = w.Name,
                                  NameAction = a.ActionName1,
                                  Money = m.Money,
                                  DateUse = m.DateUse
                              }).ToList();
                return result;
            }
        }
        }
    }

