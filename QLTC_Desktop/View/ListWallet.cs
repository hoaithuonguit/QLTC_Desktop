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
    public partial class ListWallet : Form
    {
        private int id;
        private ListWalletController controller;
        private WalletController wallet;
        public ListWallet()
        {
            controller = new ListWalletController();
            wallet = new WalletController();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            controller.BackToMain();
            this.Hide();
        }

        private void ListWallet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var source = wallet.getAllWallet();
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
