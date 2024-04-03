using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_22520442
{
    public partial class Lab02 : Form
    {
        public Lab02()
        {
            InitializeComponent();
        }

        private void bai1_Click(object sender, EventArgs e)
        {
            Lab02_bai1 bai1 = new Lab02_bai1();
            bai1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_bai2 bai2 = new Lab02_bai2();
            bai2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_bai3 bai3 = new Lab02_bai3();
            bai3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_bai4 bai4 = new Lab02_bai4();
            bai4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_bai5 bai5 = new Lab02_bai5();
            bai5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_bai6 bai6 = new Lab02_bai6();
            bai6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab02_bai07 bai7 = new Lab02_bai07();
            bai7.Show();
        }
    }
}
