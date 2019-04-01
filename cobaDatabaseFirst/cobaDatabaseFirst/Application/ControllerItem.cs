using cobaDatabaseFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaDatabaseFirst
{
    public class ControllerItem : DataManipulation, IItem
    {
        private MyContext myContext = new MyContext();
        ControllerItem controllerItem = new ControllerItem();
        bool status = false;

        public List<TB_M_Item> Get()
        {
            var get = myContext.TB_M_Item.Where(x => x.IsDelete == false).ToList();
            foreach (var list in get)
            {
                Console.Write("Id : ");
                Console.WriteLine(list.Id);
                Console.Write("Name : ");
                Console.WriteLine(list.Name);
                Console.Write("Quantity : ");
                Console.WriteLine(list.Quantity);
                Console.Write("Price : ");
                Console.WriteLine(list.Price);
            }
            return get;
        }

        public bool InsertData()
        {
            string Name;
            int Quantity, Price;
            Console.Write("Insert Item name : ");
            Name = Console.ReadLine();
            Console.Write("Insert Item Quantity : ");
            Quantity = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Item Price : ");
            Price = Convert.ToInt32(Console.ReadLine());
            TB_M_Item TB_M_Item = new TB_M_Item();
            TB_M_Item.Name = Name;
            TB_M_Item.Quantity = Quantity;
            TB_M_Item.Price = Price;
            myContext.TB_M_Item.Add(TB_M_Item);
            return Save(myContext);            
        }

        public bool EditData()
        {                        
            string Name;
            int Quantity, Price, Id;            
            Console.Write("Insert the Id : ");            
            Id = Convert.ToInt16(Console.ReadLine());
            var get = controllerItem.Get(Id);
            //var get2 = MyCon.TB_M_Items.SingleOrDefault(x => x.Id == Id);
            if (get != null)
            {
                Console.Write("Insert new name : ");
                Name = Console.ReadLine();
                Console.Write("Insert Item Quantity : ");
                Quantity = Convert.ToInt16(Console.ReadLine());
                Console.Write("Insert Item Price : ");
                Price = Convert.ToInt32(Console.ReadLine());
                get.Name = Name;
                get.Quantity = Quantity;
                get.Price = Price;
                myContext.Entry(get).State = EntityState.Modified;
                return Save(myContext);
            }
            else
            {
                Console.Write("No Data Found");
                status = false;
            }
            return status;
        }

        public bool DeleteData(int Id)
        {
            var get = controllerItem.Get(Id);
            //var get2 = MyCon.TB_M_Items.SingleOrDefault(x => x.Id == Id);
            if (get != null)
            {
                get.IsDelete = true;
                myContext.Entry(get).State = EntityState.Modified;
                return Save(myContext);                
            }
            else
            {
                Console.Write("No Data Found");
            }
            return status;
        }

        public TB_M_Item Get(int Id)
        {
            var get = myContext.TB_M_Item.Find(Id);
            if (get != null)
            {
                return get;
            }
            else
            {
                return null;
            }
        }
    }
}
