using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaOOP
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //encapsulation
        //    //kita tidak dapat mengakses atribut salary dari class bapak secara langsung
        //    //karena atribut salary hak aksesnya private
        //    //kita dapat akses atribut salary dengan method getSalary karena method tersebut public
        //    Parent bapak = new Parent();
        //    bapak.setSalary(10000);
        //    Console.WriteLine("Salary : " + bapak.getSalary());
        //    //Console.WriteLine(bapak.salary);

        //    Process p;
        //    p = new Rectangle(10, 7);
        //    p = new Circle(10);
        //    decimal c = p.processing();
        //    Console.WriteLine("Result : " + c);
        //    Console.Read();
        //}
    }

    public class Parent
    {
        protected string last_name, first_name;
        int salary;
        public void setSalary(int salaryValue)
        {
            salary = salaryValue;
        }
        public int getSalary()
        {
            return salary;
        }
    }

    public class Parent2
    {

    }

    //inheritance
    //class child mewarisi atribut first_name dan last_name dari parent
    //sebuah class hanya bisa inherit satu class
    //sebuah class bisa implement lebih dari satu class
    public class Child : Parent, asdf, jkl
    {
        string first, last;

        public Child()
        {
            first = first_name;
            last = last_name;
        }

        public void parentName()
        {
            Console.WriteLine(first_name + " " + last_name);
        }        
    }

    public interface asdf{}

    public interface jkl{}

    public abstract class Process
    {
        protected decimal circumference;
        public abstract decimal processing();
    }

    public class Rectangle : Process
    {
        protected decimal length;
        protected decimal width;

        public Rectangle(decimal a, decimal b)
        {
            length = a;
            width = b;
        }

        public override decimal processing()
        {
            circumference = 2 * width * length;
            return circumference;
        }
    }

    public class Circle : Process
    {
        protected decimal diameter;
        public Circle(decimal d)
        {
            diameter = d;
        }

        public override decimal processing()
        {
            circumference = Convert.ToDecimal(3.14) * diameter;
            return circumference;
        }
    }
}
