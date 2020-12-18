using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18122020
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4 };
            //Console.WriteLine(SumArrayElements(arr));
            //Console.WriteLine(GetArrayAvarage(arr));
            //GetDigitAndLetterString("Salam P120");
            Student student = new Student();
            student.FullName = "Asiman Alili";
            student.Age = 26;
            Student student1 = new Student();
            student1.FullName = "Elvin Osmanov";
            student1.Age = 22;
            Student student2 = new Student();
            student2.FullName = "Resul Jafarli";
            student2.Age = 16;
            Student student3 = new Student();
            student3.FullName = "Fereh Ibrahimli";
            student3.Age = 18;
            Group group = new Group(4);
            group.Name = "P120";
            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.GetAllStudentOfGroup();
            Group group1 = new Group(6);
            group1.Name = "P507";
            group1.AddStudent(student);
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            School school = new School();
            school.Name = "Code Academy";
            school.AddGroup(group);
            school.AddGroup(group1);
            school.GetAllClass();
            school.GetAllStudentsSchool();




        }
        //public static int SumArrayElements(int[] arr)
        //{
        //    int sum = 0;
        //    foreach (int num in arr)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //}
        //public static double GetArrayAvarage(int[] arr)
        //{
        //    double sum = 0;

        //    foreach (int number in arr)
        //    {
        //        sum += number;
        //    }
        //    return sum / arr.Length;
        //}
        //public static void GetDigitAndLetterString(string str)
        //{
        //    int letterCount = 0;
        //    int digitCount = 0;
        //    foreach (char item in str)
        //    {
        //        if (Char.IsDigit(item))
        //        {
        //            digitCount++;
        //        }
        //        if (Char.IsLetter(item))
        //        {
        //            letterCount++;
        //        }
        //    }
        //    Console.WriteLine($"Herflerin sayi:{letterCount} \n Reqemlerin sayi:{digitCount}");
        //}
    }
}
