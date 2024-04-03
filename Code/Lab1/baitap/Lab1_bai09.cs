using System;
using System.Collections;
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
    public partial class Lab1_bai09 : Form
    {
        ListBox dsmonan=new ListBox();
        
        public Lab1_bai09()
        {
            InitializeComponent();
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            tbxnhap.Text = "";
            txbxuat.Text = "";
            listBox.Items.Clear();
        }

        private void them_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(tbxnhap.Text);
            
            
        }

        private void Timmonan_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int index=rnd.Next(0, listBox.Items.Count);
            listBox.SelectedIndex = index;
            string monan = listBox.SelectedItem.ToString();
            txbxuat.Text = monan;
        }
    }
}
