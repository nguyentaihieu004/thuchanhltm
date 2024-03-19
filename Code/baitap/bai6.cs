using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class bai6 : Form
    {
        public bai6()
        {
            InitializeComponent();
        }

        private void bai6_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _ngay = Int32.Parse(ngay.Text);
            int _thang=Int32.Parse(thang.Text);
            switch(_thang){
                case 1:
                    if (_ngay >= 21) textBox2.Text = "cung Bảo Bình";
                    else if (_ngay <= 20) textBox2.Text = "cung Ma Kết";
                    break;
                case 2:
                    if (_ngay >= 20) textBox2.Text = "cung Song Ngư";
                    else if (_ngay <= 19) textBox2.Text = "cung Bảo Bình";
                    break;
                case 3:
                    if (_ngay >= 21) textBox2.Text = "cung Bạch Dương";
                    else if (_ngay <= 20) textBox2.Text = "cung Song Ngư";
                    break;
                case 4:
                    if (_ngay >= 21) textBox2.Text = "cung Kim Ngưu";
                    else if (_ngay <= 20) textBox2.Text = "cung Bạch Dương";
                    break;
                case 5:
                    if (_ngay >= 22) textBox2.Text = "cung Song Tử";
                    else if (_ngay <= 21) textBox2.Text = "cung Kim Ngưu";
                    break;
                case 6:
                    if (_ngay >= 22) textBox2.Text = "cung Cự Giải";
                    else if (_ngay <= 21) textBox2.Text = "cung Song Tử";
                    break;
                case 7:
                    if (_ngay >= 23) textBox2.Text = "cung Sư Tử";
                    else if (_ngay <= 22) textBox2.Text = "cung Cự Giải";
                    break;
                case 8:
                    if (_ngay >= 23) textBox2.Text = "cung Xử Nữ";
                    else if (_ngay <= 22) textBox2.Text = "cung Sư Tử";
                    break;
                case 9:
                    if (_ngay >= 24) textBox2.Text = "cung Thiên Bình";
                    else if (_ngay <= 23) textBox2.Text = "cung Xử Nữ";
                    break;
                case 10:
                    if (_ngay >= 24) textBox2.Text = "cung Thần Nông";
                    else if (_ngay <= 23) textBox2.Text = "cung Thiên Bình";
                    break;
                case 11:
                    if (_ngay >= 23) textBox2.Text = "cung Nhân Mã";
                    else if (_ngay <= 22) textBox2.Text = "cung Thần Nông";
                    break;
                case 12:
                    if (_ngay >= 22) textBox2.Text = "cung Ma Kết";
                    else if (_ngay <= 21) textBox2.Text = "cung Nhân Mã";
                    break;
            }
        }
    }
}
