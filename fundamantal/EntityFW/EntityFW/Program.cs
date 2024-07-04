using EntityFW.model;
using EntityFW.model.entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EntityFW
{
    public class Program
    {
        public static void CreatDatabase()
        {
            using (var dbContext = new TestE())
            {
                try
                {
                    string nameDb = dbContext.Database.GetDbConnection().Database;
                    dbContext.Database.EnsureCreated();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            //Console.WriteLine(nameDb);
        }

        public static void DropDatabase() {
            using (var dbContext = new TestE())
            {

                string nameDb = dbContext.Database.GetDbConnection().Database;
                try
                {
                    dbContext.Database.EnsureDeleted();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                } finally
                {
                    Console.WriteLine("finish drop");
                }
            }
        }
        // part 1
        /*
        static void InsertProduct()
        {
            using (var dbContext = new TestE())
            {
                // model ()
                // add , addasyc
                // SaveChange / SaveChangeAsyc

                var p1 = new Product();
                
                p1.NameProduct = "pro1";
                p1.Quantity = 100;

                dbContext.Add(p1);
                dbContext.SaveChanges(); //=> return so dong tac dong
            }
        }

        static async void InsertPAsyc()
        {
            var dbContext = new TestE();
            Product p1 = new Product();
            p1.IDProduct = 1;
            p1.NameProduct = "pro1";
            p1.Quantity = 100;
            
            dbContext.AddAsync(p1);

            dbContext.SaveChangesAsync();
        }

        static void AddManyProduct()
        {
            using (var dbContext = new TestE())
            {
                // model ()
                // add , addasyc
                // SaveChange / SaveChangeAsyc

              var ps = new Object[] 
              {
                  new Product(){NameProduct = "p2" , Quantity = 2},
                  new Product(){NameProduct = "p3" , Quantity = 3},
                  new Product(){NameProduct = "p4" , Quantity = 4},
                  new Product(){NameProduct = "p5" , Quantity = 5},
              };

                dbContext.AddRange(ps);
                dbContext.SaveChanges(); //=> return so dong tac dong
            }
        }

        static void ReadProduct()
        {
            var dbContext = new TestE();

            //List<Product> read = dbContext.products.Where(e => e.IDProduct == 1).ToList();

            var read = from Product in dbContext.products
                       where Product.IDProduct >= 2
                       select Product;

            read.ToList().ForEach(e =>
            {
                Console.WriteLine(e.ToString());
            });
        }

        public static void Renameproduct(int id, string newNameProduct)
        {
            using (var dbContext = new TestE())
            {
                var find = (from Product in dbContext.products
                            where Product.IDProduct == id
                            select Product).FirstOrDefault();

                if (find != null)
                {
                    EntityEntry<Product> entityEntry = dbContext.Entry(find); // đối tượng theo dõi sự thay đổi trong db context
                    //entityEntry.State = Microsoft.EntityFrameworkCore.EntityState.Detached; // loại bỏ sự thay đổi trong context 

                    find.NameProduct = newNameProduct;
                    dbContext.SaveChanges();
                }
            }

        }

        public static void Deleteproduct(int id)
        {
            using (var dbContext = new TestE())
            {
                var find = (from Product in dbContext.products
                            where Product.IDProduct == id
                            select Product).FirstOrDefault();

                if (find != null)
                {
                    EntityEntry<Product> entityEntry = dbContext.Entry(find); // đối tượng theo dõi sự thay đổi trong db context
                    //entityEntry.State = Microsoft.EntityFrameworkCore.EntityState.Detached; // loại bỏ sự thay đổi trong context 
                    dbContext.Remove(find);
                    dbContext.SaveChanges();
                }
            }
        }
        */

        public static void AddDaTaPart2()
        {
            using (var dbContext = new TestE())
            {
                Category category = new Category()
                {
                    Name = "car1",
                    Description = "d1",
                };

                dbContext.Add(category);

                var ps = new Object[]
             {
                  new Product(){NameProduct = "p2" , Quantity = 2 , Category = category},
                  new Product(){NameProduct = "p3" , Quantity = 3, Category = category},
                  new Product(){NameProduct = "p4" , Quantity = 4, Category = category},
                  new Product(){NameProduct = "p5" , Quantity = 5, Category = category},
             };

                dbContext.AddRange(ps);
                dbContext.SaveChanges();
            }

        }

        public static void QueryPart2()
        {
            using ( var dbContext = new TestE())
            {
                var product = (from p in dbContext.products 
                              where p.IDProduct ==2
                              select p).SingleOrDefault();

                //Console.WriteLine(product.Category.IDCategory); // nhu nay se khong dc
                var e = dbContext.Entry(product);

                e.Reference(pro => pro.Category).Load(); // truy van den attri reference
                Console.WriteLine(product.Category.IDCategory);

            }
        }
        static void Main(string[] args)
        {


            //DropDatabase();
            CreatDatabase();
            //AddDaTaPart2();

            //QueryPart2();
            //AddManyProduct();
            //ReadProduct();
            //Renameproduct(1, "testReName");
            //Deleteproduct(1);
            Console.ReadKey();
        }
    }
}
