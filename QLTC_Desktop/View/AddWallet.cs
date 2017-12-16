using QLTC_Desktop.Controllers;
using QLTC_Desktop.ResponsityController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC_Desktop.View
{
    public partial class AddWallet : Form
    {
        private AddWallerController controller;
       // private WalletController control;
        public AddWallet()
        {
            controller = new AddWallerController();
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if
            (
            controller
            .CheckDataInput(tvName.Text, int.Parse(tvMoney.Text))
            .Equals("Success")
            )
                if (
                   controller.Add(tvName.Text, int.Parse(tvMoney.Text))
                    .Equals("1")
                    )
                    MessageBox.Show("Đã tồn tại ví tiền!");
            else
                {
                    MessageBox.Show("Đã thêm!");
                    Main m = new Main();
                    m.Show();
                    this.Hide();
                }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            controller.BackToMain();
            this.Hide();
        }
    }
}
