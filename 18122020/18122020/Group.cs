using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18122020
{
    class Group
    {
        public string Name { get; set; }
        private int _capacity { get; set; }
        public int Capacity {
            get 
            {
                return this._capacity;
            }
        }
        public Student[] Students { get; set; }
        public Group(int capacity)
        {
            this._capacity = capacity;
            Students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            if (this.Students.Length < _capacity)
            {
                var arr = this.Students;
                Array.Resize(ref arr, this.Students.Length + 1);
                arr[arr.Length - 1] = student;
                this.Students = arr;
            }
            else
            {
                Console.WriteLine($"Sinifin maksimal hecmi {this._capacity}-dir");
            }
        }
        public void GetAllStudentOfGroup()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"Telebenin Adi ve Soyadi:{student.FullName}");
            }
        }
    }
}
