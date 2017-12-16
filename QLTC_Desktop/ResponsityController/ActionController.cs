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
   public class ActionController
    {
        public List<ActionViewModel> getByWallet(int id)
        {
            using (var context = new QLTCDbEntities())
            {
                var result = (from a in context.ActionNames
                              from w in context.Wallets
                              from m in context.MemoryActions
                              where a.ID.Equals(m.ID_action)
                                    && w.ID.Equals(m.ID_wallet)
                                    && m.ID_wallet.Equals(id)
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
        public List<String> getAllAction()
        {
            using (var context = new QLTCDbEntities())
            {
                var result = (from a in context.ActionNames
                              select a.ActionName1).ToList();
                return result;
            }
        }
        public String checkValidate(String name)
        {
            using (var context = new QLTCDbEntities())
            {
                var check = (from a in context.ActionNames
                             where a.ActionName1.Equals(name)
                             select a).ToList();
                if (check.Count() > 0) return "Tên hoạt động đã tồn tại";
                else return "Success";
            }
        }
        public void AddAction(String name)
        {
            using (var context = new QLTCDbEntities())
            {
                var i = (from a in context.ActionNames
                         select a).ToList();
                int id = i.Count();
                id++;
                ActionName action = new ActionName()
                {
                    ID = id,
                    ActionName1 = name
                };
                context.ActionNames.Add(action);
                context.Entry(action).State = EntityState.Added;
                context.SaveChanges();
            }
        }
        
    }
}
