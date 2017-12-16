using QLTC_Desktop.Controllers;

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
    public partial class AddSpending : Form
    {
        private SpendingController control;
        public AddSpending()
        {
            control = new SpendingController();
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddSpending_Load(object sender, EventArgs e)
        {
            List<String> action = new List<string>();
            action = control.getAction();
            for(int i = 0; i< action.Count(); i++)
            {
                cbAction.Items.Add((action[i]));
            }
            List<String> w = new List<string>();
            w = control.getWallet();
            for (int i= 0; i< w.Count(); i++)
            {
                cbWallet.Items.Add(w[i]);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int money = int.Parse(tbMoney.Text);
            if(control.addNewSpending(cbAction.Text,
                                        cbWallet.Text,
                                        money,
                                        dateTimePicker1.Value).Equals("Success"))
            {
                MessageBox.Show("đã thêm");
                control.Back();
                this.Hide();
            }
            else
            {
                MessageBox.Show(control.addNewSpending(cbAction.Text,
                                        cbWallet.Text,
                                        money,
                                        dateTimePicker1.Value));
            }
                   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            control.Back();
            this.Hide();
        }

        private void bnAddAction_Click(object sender, EventArgs e)
        {
            control.OpenAddAction();
            this.Hide();
        }

        private void btnAddWallet_Click(object sender, EventArgs e)
        {
            control.OpenAddWallet();
            this.Hide();
        }
    }
}
