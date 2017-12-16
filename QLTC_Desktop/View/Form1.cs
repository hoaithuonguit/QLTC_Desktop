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

namespace QLTC_Desktop
{
    public partial class Form1 : Form
    {
        private LoginControllers controller;
        public Form1()
        {
            controller = new LoginControllers();
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( controller.doLogin(controller.CheckValidation(tvName.Text, tvPass.Text)))
            this.Hide();
        }
    }
}
