using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Lab1_bai03 : Form
    {
        public Lab1_bai03()
        {
            InitializeComponent();
        }

        private void txbnhap_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txbnhap.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Int32.Parse(txbnhap.Text.Trim());
            switch (num)
            {
                case 1:
                    txbketqua.Text = "Một";
                    break;
                case 2:
                    txbketqua.Text = "Hai";
                    break;
                case 3:
                    txbketqua.Text = "Ba";
                    break;
                case 4:
                    txbketqua.Text = "Bốn";
                    break;
                case 5:
                    txbketqua.Text = "Năm";
                    break;
                case 6:
                    txbketqua.Text = "Sáu";
                    break;
                        
                case 7:
                    txbketqua.Text = "Bảy";
                    break;
                case 8:
                    txbketqua.Text = "Tám";
                    break;
                case 9:
                    txbketqua.Text = "Chín";
                    break;
                case 0:
                    txbketqua.Text = "Không";
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txbnhap.Text = "";
            txbketqua.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
