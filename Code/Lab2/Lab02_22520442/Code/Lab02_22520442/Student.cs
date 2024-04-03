using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace classStudent
{ 
    public class Student

    {
        private float c1;
        private float c2;
        private float c3;

        public string Name { set; get; }
        public int MSSV { set; get; }
        public string Phone { set; get; }
        public float Course1 { set; get; }
        public float Course2 { set; get; }
        public float Course3 { set; get; }
        public float Average { set; get; }

        public Student(string _Name, int _MSSV, string _Phone, float _Course1, float _Course2, float _Course3)
        {
            Name = _Name;
            MSSV = _MSSV;
            Phone = _Phone;
            Course1 = _Course1;
            Course2 = _Course2;
            Course3 = _Course3;
        }

        public Student(string name, int mssv, float c1, float c2, float c3)
        {
            Name = name;
            MSSV = mssv;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }
        public float TBC()
        {
            float tmp = 0;
            tmp = (this.Course1 + this.Course2 + this.Course3)/3;
            return tmp;
        }
        
    }
}
