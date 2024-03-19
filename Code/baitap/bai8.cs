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
    public partial class bai8 : Form
    {
        public bai8()
        {
            InitializeComponent();
        }

        
        string tmp;
        string[] nhap;
        
        string[] newarray;
        private bool isnume(string a)
        {
            return double.TryParse(a, out _);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            tmp=textBox1.Text;
            nhap=tmp.Split(',');
            bool ktra = true;
            if (isnume(nhap[0].Trim()))
            {
                MessageBox.Show("Nhập dữ liệu sai");
            }
            else
            {
                if (tmp.Length >= 2)
                {
                
                    for(int i = 1; i < nhap.Length; i++)
                    {
                        if (!isnume(nhap[i].Trim())){
                            ktra=false;
                            break;
                        }
                    }
                }
                if (ktra == false)
                {
                    MessageBox.Show("Nhập dữ liệu sai");
                }
            }
            
        }
        private bool isValue(string[] chuoi,double a)
        {
            foreach(var tmp in chuoi)
            {
                if(double.TryParse(tmp,out double value)){
                    if(value<a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
       
        private void btkiemtra_Click(object sender, EventArgs e)
        {
            txbhoten.Text = nhap[0];
            string diem = "";
            for(int i = 1;i< nhap.Length;i++)
            {
                diem += "Môn " + i + ": " + nhap[i] +" ";  
            }
            txbdiem.Text = diem;
            newarray = new string[nhap.Length - 1];
            Array.Copy(nhap,1,newarray,0,nhap.Length-1);

            double sum=0;
            for(int i = 0;i<newarray.Length;i++)
            {
                sum += double.Parse(newarray[i]);
            }
            sum = sum/(newarray.Length);
            txbdtb.Text = sum.ToString();

            double min = double.Parse(newarray[0]);
            double max = double.Parse(newarray[0]); 
            for(int i = 0; i < newarray.Length;i++) {
                if (double.Parse(newarray[i]) < min)
                {
                    min= double.Parse(newarray[i]);
                }
                if (double.Parse(newarray[i]) > max)
                {
                    max= double.Parse(newarray[i]);
                }
            }
            txbmax.Text = max.ToString();
            txbmin.Text = min.ToString();

            int somondau=0;
            int somonkodau = 0;
            for(int i = 0;i< newarray.Length; i++)
            {
                if (double.Parse(newarray[i])<5) somonkodau++;
                else somondau++;
            }
            txbdau.Text = somondau.ToString();
            txbkodau.Text = somonkodau.ToString();

            if (sum >= 8 && !isValue(newarray, 6.5))
            {
                
                txbxeploai.Text = "Giỏi";
                
            }
            else if(sum >= 6.5&&!isValue(newarray, 5))
            {
                txbxeploai.Text = "Khá";
            }
            else if (sum >= 5 && !isValue(newarray, 3.5))
            {
                txbxeploai.Text = "TB";
            }
            else if ((sum >= 3.5) && !isValue(newarray, 2))
            {
                txbxeploai.Text = "Yếu";
            }
            else
            {
                txbxeploai.Text = "Kém";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txbdiem.Text = "";
            txbmin.Text = "";
            txbmax.Text = "";
            txbdtb.Text = "";
            txbdau.Text = "";
            txbkodau.Text = "";
            txbxeploai.Text = "";
            txbhoten.Text = "";
            Array.Clear(nhap, 0, nhap.Length);
            Array.Clear(newarray, 0, newarray.Length);
        }
    }
}
