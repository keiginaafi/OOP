using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaDatabaseFirst
{
    class Program
    {
        static Program program = new Program();
        static void Main(string[] args)
        {
            ControllerSuppliers controllerSupplier = new ControllerSuppliers();
            int choice, choice2;
            choice = program.Menu();
            switch (choice)
            {
                case 1:
                    choice2 = program.MenuSupplier();
                    switch (choice2)
                    {
                        case 1:
                            controllerSupplier.InsertData();
                            Console.Read();
                        case 2:

                    }
            }            
        }

        public int Menu()
        {
            int choice;
            Console.WriteLine("==============================");
            Console.WriteLine("||      Menu Transaksi      ||");
            Console.WriteLine("==============================");
            Console.WriteLine("||       1. Supplier        ||");
            Console.WriteLine("||         2. Item          ||");
            Console.WriteLine("||      3. Beli Barang      ||");
            Console.WriteLine("||    4. Ubah transaksi     ||");
            Console.WriteLine("==============================");
            Console.Write("Pilihanmu : ");
            choice = Convert.ToInt16(Console.ReadLine());
            return choice;
        }

        public int MenuSupplier()
        {
            int choice;
            Console.WriteLine("==============================");
            Console.WriteLine("||       Menu Supplier      ||");
            Console.WriteLine("==============================");
            Console.WriteLine("||       1. View All        ||");
            Console.WriteLine("||    2. Insert new data    ||");
            Console.WriteLine("||       3. Edit data       ||");
            Console.WriteLine("||      4. Delete data      ||");
            Console.WriteLine("==============================");
            Console.Write("Pilihanmu : ");
            choice = Convert.ToInt16(Console.ReadLine());
            return choice;
        }

        public int MenuItem()
        {
            int choice;
            Console.WriteLine("==============================");
            Console.WriteLine("||         Menu Item        ||");
            Console.WriteLine("==============================");
            Console.WriteLine("||       1. View All        ||");
            Console.WriteLine("||    2. Insert new data    ||");
            Console.WriteLine("||       3. Edit data       ||");
            Console.WriteLine("||      4. Delete data      ||");
            Console.WriteLine("==============================");
            Console.Write("Pilihanmu : ");
            choice = Convert.ToInt16(Console.ReadLine());
            return choice;
        }

        //public int BeliBarang()
        //{
        //    ControllerItem controllerItem = new ControllerItem();
        //    controllerItem.Get();
        //    return 0;
        //}
    }
}
