using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }
        string[] Ones = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín","Mười", "Mười một", "Mười hai", "Mười ba", "Mười bốn", "Mười lăm", "Mười sáu", "Mười bảy", "Mười tám", "Mười chín" };
        string[] Tens = { "Mười", "Hai mươi", "Ba mươi", "Bốn mươi", "Năm mươi", "Sáu mươi", "Bảy mươi", "Tám mươi", "Chín mươi" };
        private String ReadTram(long num1)
        {
            string strword = "";
            if (num1 > 99 && num1 < 1000)
            {
                long i = num1 / 100;
                strword = strword + Ones[i - 1] + " Trăm ";
                num1= num1 % 100;
               
            }
            if(num1>19&& num1 < 100)
            {
               long y = num1 / 10;
                strword = strword + Tens[y - 1] + " ";
                num1 = num1 % 10;
            }
            if(num1>0&& num1 < 20)
            {
                strword += Ones[num1 - 1];
            }
            
            return strword;
        }
        private String ReadNghin(long num1)
        {
            if (num1 > 999 && num1 < 1000000)
                return ReadTram(num1 / 1000) + " Nghìn " + ReadTram(num1 % 1000);
            else return ReadTram(num1);
        }
        private String ReadTrieu(long num1)
        {
            if (num1 > 999999 && num1 < 1000000000)
            {
                return ReadTram(num1 / 1000000) + " Triệu " + ReadNghin(num1%1000000);
            }
            else return ReadNghin(num1);
        }
        private String ReadTy(long num1)
        {
            if(num1 > 999999999 && num1 < 1000000000000)
            {
                return ReadTram(num1 / 1000000000) + " Tỷ " + ReadTrieu(num1 % 1000000000);
            }
            else return ReadTrieu(num1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            txbketqua.Text = ReadTy(long.Parse(txbnhap.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txbketqua.Text = "";
            txbnhap.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
