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
    public partial class LookUp : Form
    {
        private LookUpController control;
        public LookUp()
        {
            control = new LookUpController();
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            if (dtpkFrom.Value > dtpkTo.Value)
            {
                MessageBox.Show("Thời gian bắt đầu và kết thúc không hợp lí");
            }
            else
            {
                var source = control.search(dtpkFrom.Value, dtpkTo.Value);
                dataGridView1.DataSource = source;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            control.Back();
            this.Hide();
        }

        private void LookUp_Load(object sender, EventArgs e)
        {
            var source = control.getAll();
            dataGridView1.DataSource = source;
        }
    }
}
