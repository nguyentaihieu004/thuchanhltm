﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Lab1_KeyDown;
        }
        private Lab1_bai01 bai1Instance;
        private Lab1_bai02 bai2Instance;
        private Lab1_bai03 bai3Instance;
        private Lab1_bai04 bai4Instance;
        private Lab1_bai05 bai5Instance;
        private Lab1_bai06 bai6Instance;
        private Lab1_bai07 bai7Instance;
        private Lab1_bai08 bai8Instance;
        private Lab1_bai09 bai9Instance;
        private void bai1_Click(object sender, EventArgs e)
        {
            if(bai1Instance == null || bai1Instance.IsDisposed)
            {
                bai1Instance = new Lab1_bai01();
                bai1Instance.Show();
            }
            else
            {
                bai1Instance.BringToFront();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bai2Instance==null || bai2Instance.IsDisposed)
            {
                bai2Instance = new Lab1_bai02();
                bai2Instance.Show();
            }
            else
            {
                bai2Instance.BringToFront();
            }
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            if (bai3Instance == null || bai3Instance.IsDisposed)
            {
                bai3Instance = new Lab1_bai03();
                bai3Instance.Show();
            }
            else
            {
                bai3Instance.BringToFront();
            }
        }
         private void Bai4_Click(object sender, EventArgs e)
        {
            if (bai4Instance == null || bai4Instance.IsDisposed)
            {
                bai4Instance = new Lab1_bai04();
                bai4Instance.Show();
            }
            else
            {
                bai4Instance.BringToFront();
            }
        }
        private void bai5_Click(object sender, EventArgs e)
        {
            if (bai5Instance == null || bai5Instance.IsDisposed)
            {
                bai5Instance = new Lab1_bai05();
                bai5Instance.Show();
            }
            else
            {
                bai5Instance.BringToFront();
            }
        }
        private void Lab1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Q)
            {
                CloseAllForm();
            }
        }
        private void CloseAllForm()
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form != this)
                {
                    form.Close();
                }
            }
        }

        private void bai6_Click(object sender, EventArgs e)
        {
            if (bai6Instance == null || bai6Instance.IsDisposed)
            {
                bai6Instance = new Lab1_bai06();
                bai6Instance.Show();
            }
            else
            {
                bai6Instance.BringToFront();
            }
        }

        private void bai7_Click(object sender, EventArgs e)
        {
            if (bai7Instance == null || bai7Instance.IsDisposed)
            {
                bai7Instance = new Lab1_bai07();
                bai7Instance.Show();
            }
            else
            {
                bai7Instance.BringToFront();
            }
        }

        private void bai8_Click(object sender, EventArgs e)
        {
            if (bai8Instance == null || bai8Instance.IsDisposed)
            {
                bai8Instance = new Lab1_bai08();
                bai8Instance.Show();
            }
            else
            {
                bai8Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bai9Instance == null || bai9Instance.IsDisposed)
            {
                bai9Instance = new Lab1_bai09();
                bai9Instance.Show();
            }
            else
            {
                bai1Instance.BringToFront();
            }
        }
    }
}
