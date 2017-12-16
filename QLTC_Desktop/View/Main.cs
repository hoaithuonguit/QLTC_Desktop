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
    public partial class Main : Form
    {
        private MainController controller;
        private WalletController wallet;
        private ActionController action;
        public Main()
        {
            controller = new MainController();
            wallet = new WalletController();
            action = new ActionController();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void thêm1VíTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.OpenAddWallet();
            this.Hide();
        }

        private void danhSáchCácVíTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.OpenListWallet();
            this.Hide();
        }

        private void thêmKhoảngThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.AddNewMoney();
            this.Hide();
        }

        private void thêmKhoảngChiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.AddNewSpending();
            this.Hide();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.OpenLookUp();
            this.Hide();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.OpenInfo();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbMoney.Text = controller.getSum().ToString();
            LoadDataWallet(dtgvWallet);
        }
        private void LoadDataWallet(DataGridView dtgv)
        {
            var source = controller.getWallet();
            dtgv.DataSource = source;

        }

        private void dtgvWallet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var source = action.getByWallet(e.RowIndex + 1);
            if (source!= null)
            dtgvAction.DataSource = source;
        }
    }
}
