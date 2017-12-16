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
    public partial class AddAction : Form
    {
        private AddActionController control;
        public AddAction()
        {
            control = new AddActionController();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (control.CheckValidate(textBox1.Text).Equals("Success"))
            {
                //them
                control.AddAction(textBox1.Text);
                MessageBox.Show("Đã thêm");
                control.Cancel();
                this.Hide();
            }
            else
                MessageBox.Show(control.CheckValidate(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            control.Cancel();
            this.Hide();
        }
    }
}
