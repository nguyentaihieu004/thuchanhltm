using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_22520442
{
    public partial class Lab02_bai1 : Form
    {
        public Lab02_bai1()
        {
            InitializeComponent();
        }
        string input = "";
        private void docfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdl = new OpenFileDialog();
            opdl.ShowDialog();
            FileStream fs = new FileStream(opdl.FileName, FileMode.Open);
            StreamReader rs = new StreamReader(fs);
            input= rs.ReadToEnd();
            richTextBox1.Text= input;
            rs.Close();
            fs.Close();
            
        }

        private void ghifile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdl = new OpenFileDialog();
            opdl.ShowDialog();
            FileStream fs = new FileStream(opdl.FileName, FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw= new StreamWriter(fs);
            string tmp=input.ToUpper();
            sw.Flush();
            sw.Write(tmp);
            sw.Close();
            fs.Close ();
        }
    }
}
