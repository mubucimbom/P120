using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11122020
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Human(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
    public class Teacher:Human
    {
        public int Experiance { get; set; }
        public Teacher(int experiance,string name,string surname):base(name,surname)
        {
            this.Experiance = experiance;
        }
    }

}
