using QLTC_Desktop.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC_Desktop.Controllers
{
    public class LoginControllers
    {
        //check username + password
        public String CheckValidation(String username, String Password)
        {
            if (username.Equals("admin") && Password.Equals("1234567890"))
                return "Success";
            else
            {
                String message = "";
                int check = 0;
                if (username.Equals(""))
                {
                    message += "Tên đăng nhập ";
                    check = 1;
                }
                if (Password.Equals(""))
                {
                    if (check == 0)
                        message += "Mật khẩu ";
                    else message += "và mật khẩu ";
                }
                if (!message.Equals("")) return message += "không được để trống";
                else return "Tên đăng nhập hoặc mật khẩu không chính xác";
            }
        }

        public bool doLogin(String message)
        {
            if (message.Equals("Success"))
            {
                Main fav = new Main();
                fav.Show();
                return true;
            }
            else
                MessageBox.Show(message);
            return false;
        }
    }
}
