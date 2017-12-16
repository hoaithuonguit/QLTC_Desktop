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
    public class LookUpController
    {
        private HistoryAction control;
        public LookUpController()
        {
            control = new HistoryAction();
        }
        public void Back()
        {
            Main m = new Main();
            m.Show();
        }
        public List<ActionViewModel> search(DateTime start, DateTime end)
        {
            return control.search(start, end);
        }
        public List<ActionViewModel> getAll()
        {
            return control.GetAll();
        }
    }
}
