using QLTC_Desktop.ResponsityController;
using QLTC_Desktop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC_Desktop.Controllers
{
    public class AddActionController
    {
        private ActionController control;
        public void Cancel()
        {
            Main m = new Main();
            m.Show();
        }
        public AddActionController()
        {
            control = new ActionController();
        }
        public String CheckValidate(String name)
        {
           
            if (name.Equals(""))
                return "Tên không được để trống.";
            return control.checkValidate(name);
        }
        public void AddAction(String name)
        {
           
            control.AddAction(name);
        }
    }
}
