using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11122020
{
    public class Animal
    {
        public Cat[] catArr;
        private int _no { get; set; }
        public int No {
            get
            {
                return _no;
            }
        }
        public string Sort { get; set; }
        public int Age { get; set; }
        public string Name;
        public Animal()
        {
            _no++;
           
        }
       
        public  string Eat()
        {
            string eating = "Eat as animal";
            return eating;
        }
        public int Sum(int num1,int num2)
        {
           
            return num1 + num2;
        }
    }
    public class Cat : Animal
    {
        public string Bigh { get; set; }
        public Cat(string bigh,int age,string name)
        {
            this.Bigh = bigh;
        }
       
    }
}
