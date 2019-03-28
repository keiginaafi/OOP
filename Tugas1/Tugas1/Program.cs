using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas1
{
    class Program
    {
        Program kali = new Program();

        static void Main(string[] args)
        {            
            int firstNumber;
            int secondNumber;
            //decimal result;            
            
            //input dari user
            Console.Write("Insert First Number : ");
            firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Second Number : ");
            secondNumber = Convert.ToInt16(Console.ReadLine());

            //menampilkan hasil
            //Console.WriteLine("Multiply Result : " + (firstNumber * secondNumber));            
            //result = kali.Multiply(firstNumber, secondNumber);
            //Console.WriteLine("Multiply Result : " + result);
            //Console.WriteLine(result);

            //memanggil method ShowMultiply, dan Multiply
            kali.ShowMultiply(firstNumber, secondNumber);
            //Console.WriteLine("Multiply Result : " + kali.Multiply(firstNumber, secondNumber));
            Console.Read();
        }

        public int Multiply(int theNumber, int multiplier)
        {
            int i;
            int number2;            
            number2 = 0;
            if (multiplier < 1)
            {
                for (i = multiplier; i < 0; i++)
                {
                    number2 = number2 - theNumber;
                }
                return number2;
            }
            else
            {
                for (i = 1; i <= multiplier; i++)
                {
                    number2 = number2 + theNumber;
                }
                return number2;
            }
        }

        public void ShowMultiply(decimal theNumber, decimal multiplier)
        {
            decimal i;
            decimal j;
            decimal result;
            decimal number2;
            decimal smaller;            
            number2 = 0;            
            if(multiplier < 1)
            {
                for (i = multiplier; i < 0; i++)
                {
                    number2 = number2 - theNumber;
                }
                Console.WriteLine(number2);
            }            
            else
            {
                for (i = 1; i <= multiplier; i++)
                {                    
                    number2 = number2 + theNumber;
                }                
                Console.WriteLine(number2);
            }
        }
    }
}
