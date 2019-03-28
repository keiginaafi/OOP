using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp24
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number;
            //Console.Write("Insert any number : ");
            //number = Convert.ToInt16(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //Program call = new Program();
            //int a;
            //int b;
            //Console.Write("Insert First Number : ");
            //a = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Insert Second Number : ");
            //b = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Multiply Result : ");
            //call.Kali(a, b);
            //Console.Read();

            int a;
            int b;
            int c;
            Console.Write("Insert First Number : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Second Number : ");
            b = Convert.ToInt16(Console.ReadLine());
            c = a * b;
            Console.Write("Multiply Result : " + c);
            Console.Read();
        }

        public void Kali(int a, int b)
        {
            int c;
            c = a * b;
            Console.WriteLine(c);
        }
    }
}
