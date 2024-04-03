using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classStudent
{ 
    public class Student

    {
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
    }
}
