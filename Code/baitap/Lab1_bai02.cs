﻿using System;
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
    public partial class Lab1_bai02 : Form
    {
        public Lab1_bai02()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tim_Click(object sender, EventArgs e)
        {
      
            double so_lonnhat;
            double so_nhonhat;
            if (textBox1.Text == textBox2.Text && textBox1.Text == textBox3.Text)
            {
                MessageBox.Show("Ba số bằng nhau");
            }
            else
            {
            so_lonnhat=Math.Max(double.Parse(textBox1.Text),Math.Max(double.Parse(textBox2.Text), double.Parse(textBox3.Text)));
            so_nhonhat = Math.Min(double.Parse(textBox1.Text), Math.Min(double.Parse(textBox2.Text), double.Parse(textBox3.Text)));
            textBox4.Text = so_lonnhat.ToString();
            textBox5.Text = so_nhonhat.ToString();
            }
            
            

        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
