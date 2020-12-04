using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04122020
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comment
            //ctrl+k+c
            //int a = 5;
            //int b = 6;
            //int result = a + b;
            //ctrl+k+u

            /* int a = 5;
             int b = 6;
             int result = a + b;*/
            #endregion
            #region TryParse
            //int a, b;
            //string astr, bstr;
            //bool c;
            //do
            //{
            //    Console.WriteLine("1-ci Ededi daxil edin");
            //    astr = Console.ReadLine();
            //    c = int.TryParse(astr, out a);
            //} while (!c);
            //do
            //{
            //    Console.WriteLine("2-ci Ededi daxil edin");
            //    bstr = Console.ReadLine();
            //    c = int.TryParse(bstr, out b);
            //} while (!c);
            //int result = a * b;
            //Console.WriteLine(result);
            #endregion
            #region Example
            //int num1, num2;
            //string num1str, num2str;
            //bool c;
            //do
            //{
            //    Console.WriteLine("1-ci ededi daxil edin:");
            //    num1str = Console.ReadLine();
            //    c = int.TryParse(num1str, out num1);
            //} while (!c);
            //do
            //{
            //    Console.WriteLine("2-ci ededi daxil edin:");
            //    num2str = Console.ReadLine();
            //    c = int.TryParse(num2str, out num2);
            //} while (!c);
            //Console.WriteLine(SumNumbers(num1, num2));
            #endregion
            #region Tasks
            //Task1
            //int n;
            //int counter = 0;
            //string nstr;
            //int lastdigit;
            //bool c;
            //do
            //{
            //    Console.WriteLine("Ededi daxil edin:");
            //    nstr = Console.ReadLine();
            //    c = int.TryParse(nstr, out n);
            //} while (!c);

            //while (n>0)
            //{
            //    lastdigit = n % 10;
            //    if (lastdigit != 0) counter++;
            //    n = (n - lastdigit) / 10;
            //}
            //Console.WriteLine( $"Ededdeki 0 olmayanlarin sayi {counter} ededdir");
            //Task2
            //int n ;
            //string nstr;
            //bool c;
            //do
            //{
            //    Console.WriteLine("Ededi daxil edin:");
            //    nstr = Console.ReadLine();
            //    c = int.TryParse(nstr, out n);
            //} while (!c);
            //int faktorial = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    faktorial *= i;
            //}
            //Console.WriteLine(faktorial);
            //if (faktorial%2==0)
            //{
            //    Console.WriteLine("Faktorialdan alinmish netice cutdur");
            //}
            //else
            //{
            //    Console.WriteLine("Faktorialdan alinmish netice tekdir");
            //}
            #endregion


        }
        #region ExampleMethod
        //static int SumNumbers(int num1,int num2)
        //{
        //    int result = num1 + num2;
        //    return result;
        //}
        #endregion


    }
}
