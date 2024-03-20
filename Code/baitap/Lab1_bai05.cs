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
    public partial class Lab1_bai05 : Form
    {
        public Lab1_bai05()
        {
            InitializeComponent();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            txbKqtQua.Text = "";
            textboxA.Text = "";
            textboxB.Text = "";
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tinh_Click(object sender, EventArgs e)
        {
           
            if(comboBox1.SelectedIndex == 0)
            {
                String[] Bangcuuchuong=new string[9];
                int num=Int32.Parse(textboxB.Text)- Int32.Parse(textboxA.Text);
                for(int i = 1; i < 10; i++)
                {
                    Bangcuuchuong[i-1] = num + " * " + i + " = " + num * i +Environment.NewLine;
                    
                }
                txbKqtQua.Text = string.Join("",Bangcuuchuong);
            }
            if (comboBox1.SelectedIndex == 1)
            {
                String[] Tinhgiatri=new string[2];
                int a = Int32.Parse(textboxA.Text);
                int b=Int32.Parse(textboxB.Text);

                int num = Int32.Parse(textboxA.Text) - Int32.Parse(textboxB.Text);
                int giaithua = 1;
                for(int i = 1; i <= num; i++)
                {
                    giaithua *= i;
                }
                Tinhgiatri[0]="(A-B)! = "+giaithua.ToString() + Environment.NewLine;
                int sum = 0;
                for(int i = 1; i <= b; i++)
                {
                    sum += (int)Math.Pow(a,i);
                }
                Tinhgiatri[1] ="Tổng S = "+ sum.ToString();
                txbKqtQua.Text=string.Join("",Tinhgiatri);
            }
            
        }

        private void txbKqtQua_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
