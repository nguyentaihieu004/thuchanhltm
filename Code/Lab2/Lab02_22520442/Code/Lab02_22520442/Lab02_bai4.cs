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
        static void SerializeToFileStream(String filePath,List<Student> students)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach(Student student in students)
                    {
                        writer.WriteLine($"{student.Name},{student.MSSV},{student.Phone},{student.Course1},{student.Course2},{student.Course3}");
                    }
                   
                }
                MessageBox.Show("Đã ghi dữ liệu xuống tệp input4.txt thành công.");
            }
            catch 
            {
                MessageBox.Show("Lỗi ghi file");
            }
        }
        static List<Student> DeserializeFromFileStream(string filePath)
        {
            List<Student> students = new List<Student>();
            try
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 6)
                        {
                            string name = parts[0];
                            int mssv = int.Parse(parts[1]);
                            string phone= parts[2];
                            float c1= float.Parse(parts[3]);
                            float c2= float.Parse(parts[4]);
                            float c3= float.Parse(parts[5]);
                            if (name != null && phone != null)
                            {
                                students.Add(new Student(name, mssv, phone, c1, c2, c3));
                            }
                            else
                            {
                                MessageBox.Show("Name or phone is null.");
                            }
                            
                        }
                    }
                }
                MessageBox.Show("Bạn đã đọc thành công file input4.txt");
            } catch
            {
                MessageBox.Show("Lỗi đọc file");
            }
            return students;
        }
        private void Btnwrite_Click(object sender, EventArgs e)
        {
           
            SerializeToFileStream("input4.txt",students);
        }
        List<Student> lastStudent=new List<Student>();
        private void button1_Click(object sender, EventArgs e)
        {

            lastStudent = DeserializeFromFileStream("input4.txt");
            Student student = lastStudent[0];
            textBox_Name.Text = student.Name;
            textBox_ID.Text = student.MSSV.ToString();
            textBox_Phone.Text = student.Phone;
            textBox_Course1.Text = student.Course1.ToString();
            textBox_Course2.Text = student.Course2.ToString();
            textBox_Course3.Text = student.Course3.ToString();
            student.Average = student.TBC();
            textBox_Average.Text = student.Average.ToString();
          
        }
        int i = 1;
        private void Next_Click(object sender, EventArgs e)
        {
            if (i <= lastStudent.Count)
            {
               
                label15.Text=(i+1).ToString();
                Student student = lastStudent[i];
                textBox_Name.Text = student.Name;
                textBox_ID.Text = student.MSSV.ToString();
                textBox_Phone.Text = student.Phone;
                textBox_Course1.Text = student.Course1.ToString();
                textBox_Course2.Text = student.Course2.ToString();
                textBox_Course3.Text = student.Course3.ToString();
                student.Average = student.TBC();
                textBox_Average.Text = student.Average.ToString();
                i++;
            }
            if (i > lastStudent.Count)
            {

            }
            
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (i > 0 && i <= lastStudent.Count)
            {
                i--;
                if (i > 0)
                {
                    label15.Text = i.ToString();
                    Student student = lastStudent[i - 1]; 
                    textBox_Name.Text = student.Name;
                    textBox_ID.Text = student.MSSV.ToString();
                    textBox_Phone.Text = student.Phone;
                    textBox_Course1.Text = student.Course1.ToString();
                    textBox_Course2.Text = student.Course2.ToString();
                    textBox_Course3.Text = student.Course3.ToString();
                    student.Average = student.TBC();
                    textBox_Average.Text = student.Average.ToString();
                }
                else
                {
                    
                }
            }
        }
    }
}
