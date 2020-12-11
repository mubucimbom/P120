using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11122020
{
    class Sinif
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
        public Student[] Students { get; set; } = new Student[10];

    }
    class Student
    {
        public int Age { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private double _payment { get; set; }
        public  double  Payment {
            get
            {
                return _payment;
            }
            
        }
        public Student(double payment)
        {
            _payment = payment;
        }
    }
}
