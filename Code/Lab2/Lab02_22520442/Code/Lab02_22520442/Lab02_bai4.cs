using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.IO;
using classStudent;
using System.Runtime.Serialization;

namespace Lab02_22520442
{
    public partial class Lab02_bai4 : Form
    {
        public Lab02_bai4()
        {
            InitializeComponent();
           
        }
        List<Student> students = new List<Student>();
        int dem = 0;
        string textrich = "";
        private void buttonADD_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text.Trim().Length != 8)
            {
                MessageBox.Show("Mã số sinh viên phải có 8 chữ số.");

            }else
            {
                if(textBoxPhone.Text.Trim().Length != 10 || textBoxPhone.Text.Trim()[0] != '0')
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.");
                }
                else
                {
                    if(float.Parse(textBoxCourse1.Text.Trim())<0|| float.Parse(textBoxCourse1.Text.Trim())>10 ||
                        float.Parse(textBoxCourse2.Text.Trim()) < 0 || float.Parse(textBoxCourse2.Text.Trim()) > 10 ||
                        float.Parse(textBoxCourse3.Text.Trim()) < 0 || float.Parse(textBoxCourse3.Text.Trim()) > 10)
                    { 
                        MessageBox.Show("Bạn đã nhập điểm sai.");
                    }
                    else
                    {
                        Student tmp = new Student(textBoxname.Text.Trim(),Int32.Parse(textBoxId.Text.Trim()),textBoxPhone.Text.Trim(),
                                float.Parse(textBoxCourse1.Text.Trim()), float.Parse(textBoxCourse2.Text.Trim()), float.Parse(textBoxCourse3.Text.Trim()));
                        students.Add(tmp);
                    }
                }
            }
            textrich += students[dem].Name + '\n' + students[dem].MSSV + '\n' + students[dem].Phone + '\n' + students[dem].Course1
                 + '\n' + students[dem].Course2 + '\n' + students[dem].Course3 + '\n' + '\n';
            richTextBox1.Text = textrich;
            dem++;
        }
        static void SerializeToFileStream(Student studenttmp)
        {
            try
            {
                IFormatter formater=new BinaryFormatter();
                using (FileStream fs = File.Create("input4.txt"))
                {
                    
                    formater.Serialize(fs, studenttmp);
                }
                MessageBox.Show("Đã ghi dữ liệu xuống tệp input4.txt thành công.");
            }
            catch 
            {
                MessageBox.Show("Lỗi file");
            }
        }

        private void Btnwrite_Click(object sender, EventArgs e)
        {
            Student studenttmp = new Student("hieu",22520442,"0329217749",1,1,1);
            SerializeToFileStream(studenttmp);
        }
    }
}
