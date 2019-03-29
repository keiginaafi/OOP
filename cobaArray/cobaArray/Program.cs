using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobaArray
{
    class Program
    {        
        static void Main(string[] args)
        {
            Connection MyCon = new Connection();
            Supplier supplier = new Supplier();
            Item items = new Item();
            string Name;
            string SupplierName;
            int Id;

            //menampilkan data item
            //var get = MyCon.Items.ToList();
            //foreach (var list in get)
            //{
            //    Console.WriteLine(list.Id);
            //    Console.WriteLine(list.Name);
            //    Console.WriteLine(list.Supplier_Id);
            //}
            //Console.Read();

            //menambah data item
            Console.Write("Insert item name : ");
            Name = Console.ReadLine();
            Console.Write("Insert supplier name : ");
            SupplierName = Console.ReadLine();
            var sup_id = MyCon.Suppliers.Single(x => x.Name.Contains(SupplierName));
            items.Name = Name;
            items.Suppliers = sup_id;
            MyCon.Items.Add(items);
            var result = MyCon.SaveChanges();
            if (result > 0)
            {
                Console.Write("Insert Success");
            }
            else
            {
                Console.Write("Insert Failed");
            }
            Console.Read();

            //mengubah data item
            //Console.Write("Insert item Id : ");
            //Id = Convert.ToInt16(Console.ReadLine());
            //var get = MyCon.Items.Find(Id);
            ////var get2 = MyCon.Suppliers.SingleOrDefault(x => x.Id == Id);
            //if (get != null)
            //{
            //    Console.Write("Insert new name : ");
            //    Name = Console.ReadLine();
            //    Console.Write("Insert new supplier name : ");
            //    SupplierName = Console.ReadLine();
            //    var sup_id = MyCon.Suppliers.SingleOrDefault(x => x.Name.Contains(SupplierName));
            //    get.Name = Name;
            //    get.Suppliers = sup_id;
            //    MyCon.Entry(get).State = EntityState.Modified;
            //    var result = MyCon.SaveChanges();
            //    if (result > 0)
            //    {
            //        Console.Write("Update Successful");
            //    }
            //    else
            //    {
            //        Console.Write("Update Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No Data Found");
            //}
            //Console.Read();

            //menghapus data item
            //Console.Write("Insert item Id : ");
            //Id = Convert.ToInt16(Console.ReadLine());
            //var get = MyCon.Items.SingleOrDefault(x => x.Id == Id);
            //if (get != null)
            //{
            //    //get.IsDelete = true;
            //    MyCon.Entry(get).State = EntityState.Deleted;
            //    var result = MyCon.SaveChanges();
            //    if (result > 0)
            //    {
            //        Console.Write("Delete Successful");
            //    }
            //    else
            //    {
            //        Console.Write("Delete Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No Data Found or Already Deleted");
            //}
            //Console.Read();

            //menampilkan data supplier
            //var get = MyCon.Suppliers.ToList().Where(x => x.IsDelete == false);
            //foreach (var list in get)
            //{                
            //    Console.WriteLine(list.Id);
            //    Console.WriteLine(list.Name);
            //}
            //Console.Read();

            //menambahkan data supplier
            //Console.Write("Insert your name : ");
            //Name = Console.ReadLine();
            //supplier.Name = Name;
            //MyCon.Suppliers.Add(supplier);
            //var result = MyCon.SaveChanges();
            //if(result > 0)
            //{
            //    Console.Write("Insert Success");
            //}
            //else
            //{
            //    Console.Write("Insert Failed");
            //}
            //Console.Read();

            //mengubah data supplier
            //Console.Write("Insert your Id : ");
            //Id = Convert.ToInt16(Console.ReadLine());
            //var get = MyCon.Suppliers.Find(Id);
            ////var get2 = MyCon.Suppliers.SingleOrDefault(x => x.Id == Id);
            //if(get != null)
            //{
            //    Console.Write("Insert new name : ");
            //    Name = Console.ReadLine();
            //    get.Name = Name;
            //    MyCon.Entry(get).State = EntityState.Modified;
            //    var result = MyCon.SaveChanges();
            //    if(result > 0)
            //    {
            //        Console.Write("Update Successful");
            //    }
            //    else
            //    {
            //        Console.Write("Update Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No Data Found");
            //}
            //Console.Read();

            //menghapus data supplier
            //Console.Write("Insert the Id : ");
            //Id = Convert.ToInt16(Console.ReadLine());
            //var get = MyCon.Suppliers.Find(Id);            
            ////var get2 = MyCon.Suppliers.SingleOrDefault(x => x.Id == Id);
            //if (get != null)
            //{
            //    get.IsDelete = true;
            //    MyCon.Entry(get).State = EntityState.Modified;
            //    var result = MyCon.SaveChanges();
            //    if (result > 0)
            //    {
            //        Console.Write("Delete Successful");
            //    }
            //    else
            //    {
            //        Console.Write("Delete Failed");
            //    }
            //}
            //else
            //{
            //    Console.Write("No Data Found");
            //}
            //Console.Read();

            //percobaan array
            /*
            int[] coba = new int[5];
            for (int j = 0; j < coba.Length; j++)
            {
                coba[j] = j+1;
            }
            foreach(var asd in coba)
            {
                Console.Write("coba[] = ");
                Console.WriteLine(asd);
            }
            Console.WriteLine(" ");

            int[] angka = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < angka.Length; i++)
            {
                Console.WriteLine(angka[i]);
            }
            Console.Read();
            */
        }
    }
}