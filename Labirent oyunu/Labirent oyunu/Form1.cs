using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirent_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Duvara dokundun!!");
        }

        private void label61_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler Kazandın :)");
        }
    }
}
