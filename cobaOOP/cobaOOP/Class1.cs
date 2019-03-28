using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaOOP
{
    class MenuKeliling
    {
        static void Main(string[] args)
        {
            decimal firstNumber;
            decimal secondNumber;
            decimal thirdNumber;
            decimal keliling;
            int choice;
            Console.WriteLine("==============================");
            Console.WriteLine("||       Menu Keliling      ||");
            Console.WriteLine("==============================");
            Console.WriteLine("||       1. Segitiga        ||");
            Console.WriteLine("||       2. Lingkaran       ||");
            Console.WriteLine("||    3. Persegi Panjang    ||");
            Console.WriteLine("||       4. Trapesium       ||");
            Console.WriteLine("==============================");
            Console.Write("Pilihanmu : ");
            choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine(" ");
                    Console.WriteLine("Masukkan nilai panjang sisi A : ");
                    firstNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Masukkan nilai panjang sisi B : ");
                    secondNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Masukkan nilai panjang sisi C : ");
                    thirdNumber = Convert.ToDecimal(Console.ReadLine());

                    Process p = new Triangle(firstNumber, secondNumber, thirdNumber);
                    keliling = p.processing();
                    Console.WriteLine("Keliling : " + keliling);
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("Masukkan panjang diameter : ");
                    firstNumber = Convert.ToDecimal(Console.ReadLine());

                    Process p2 = new Circle(firstNumber);
                    keliling = p2.processing();
                    Console.WriteLine("Keliling : " + keliling);
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("Masukkan nilai panjang : ");
                    firstNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Masukkan nilai lebar : ");
                    secondNumber = Convert.ToDecimal(Console.ReadLine());

                    Process p3 = new Rectangle(firstNumber, secondNumber);
                    keliling = p3.processing();
                    Console.WriteLine("Keliling : " + keliling);
                    Console.Read();
                    break;
                case 4:
                    Console.WriteLine("Masukkan nilai panjang alas A : ");
                    firstNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Masukkan nilai panjang alas B : ");
                    secondNumber = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Masukkan nilai panjang sisi miring : ");
                    thirdNumber = Convert.ToDecimal(Console.ReadLine());

                    Process p4 = new Trapezoid(firstNumber, secondNumber, thirdNumber);
                    keliling = p4.processing();
                    Console.WriteLine("Keliling : " + keliling);
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Nomor tersebut tidak ada dalam menu");
                    Console.Read();
                    break;
            }            
        }
    }

    public class Triangle : Process
    {
        //decimal height;
        decimal baseValue;        
        decimal sideA;
        decimal sideB;
        public Triangle(decimal a, decimal b, decimal c)
        {
            sideA = a;
            baseValue = b;
            sideB = c;
        }

        public override decimal processing()
        {
            circumference = sideA + baseValue + sideB;
            return circumference;
        }
    }

    public class Trapezoid : Process
    {
        decimal firstLongSide;
        decimal secondLongSide;
        decimal hypotenuse;        
        public Trapezoid(decimal a, decimal b, decimal c)
        {
            firstLongSide = a;
            secondLongSide = b;
            hypotenuse = c;
        }

        public override decimal processing()
        {
            circumference = firstLongSide + secondLongSide + (hypotenuse * 2);
            return circumference;
        }
    }
}
