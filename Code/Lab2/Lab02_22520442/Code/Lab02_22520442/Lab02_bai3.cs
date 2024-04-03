using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;


namespace Lab02_22520442
{
    public partial class Lab02_bai3 : Form
    {
        public Lab02_bai3()
        {
            InitializeComponent();
        }
        string[] listline;
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        string line = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdl = new OpenFileDialog();
            if (opdl.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(opdl.FileName, FileMode.Open))
                    {
                        using (StreamReader rs = new StreamReader(fs))
                        {
                            line = rs.ReadToEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc file: " + ex.Message);
                }
            }

            listline=line.Split('\n');
            richTextBox1.Text = line;
        }

        static double CalculateExpression(string expression)
        {
            NCalc.Expression expr = new NCalc.Expression(expression);
            return Convert.ToDouble(expr.Evaluate());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rs_text = "";
            foreach (string tmp in listline)
            {
                string text = tmp + " = ";
                double result = CalculateExpression(tmp.Trim());
                text += result.ToString() + '\n';
                rs_text += text; // Nối chuỗi vào rs_text
            }
            richTextBox1.Text = rs_text;
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


