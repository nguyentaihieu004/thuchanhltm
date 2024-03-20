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
    public partial class Lab1_bai01 : Form
    {
        public Lab1_bai01()
        {
            InitializeComponent();
        }

        private void Tinh_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(txbsthunhat.Text.Trim());
            num2 = Int32.Parse(txbsothuhai.Text.Trim());
            sum = num1 + num2;
            txbtong.Text = sum.ToString();
        }

        private void txbsthunhat_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbsthunhat.Text))
            {
                if(!int.TryParse(txbsthunhat.Text,out int num1))
                 {
                     MessageBox.Show("Vui lòng nhập số nguyên!");
                  }
            }
            
        }

        private void txbsothuhai_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txbsothuhai.Text))
            {
                if (!int.TryParse(txbsothuhai.Text, out int num2))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên!");
                }
            }
        }
    }
}
