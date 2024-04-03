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
    public partial class Lab02_bai2 : Form
    {
        public Lab02_bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        int linecount = 0;
        int wordscount = 0;
        private void btread_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdl = new OpenFileDialog();
            opdl.ShowDialog();
            FileStream fs = new FileStream(opdl.FileName, FileMode.Open);
            StreamReader rs = new StreamReader(fs);
            while (rs.ReadLine() != null)
            {
                linecount++;
            }
            textBox4linecount.Text = linecount.ToString();
            rs.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = rs.ReadToEnd();

            richTextBox1.Text = str;

            textBox1filename.Text = opdl.SafeFileName;


            textBox2size.Text = rs.BaseStream.Length.ToString() + " bytes";

            textBox3url.Text = fs.Name.ToString();

            rs.BaseStream.Seek(0, SeekOrigin.Begin);

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] ==' '|| str[i]== '\n' || str[i]=='\t')
                {
                    wordscount++;   
                }
            }
            if (!char.IsWhiteSpace(str[str.Length - 1]))
            {
                wordscount++;
            }
            textBox5wordscount.Text = wordscount.ToString();

            textBox6characcount.Text = str.Length.ToString();
        }

        private void Lab02_bai2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
