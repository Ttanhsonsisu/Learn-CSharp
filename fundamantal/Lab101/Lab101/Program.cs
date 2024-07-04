using Lab101.Customer;
using Lab101.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab101
{
    using Customer;
    using Order;

    namespace Customer
    {
        class Cust_details
        {
            public string strName;
            public void getName()
            {
                Console.WriteLine("nhap ten: ");
                strName = Console.ReadLine();
            }
        }

    }

    namespace Order
    {
        class Grocery_items
        {
            public void Ord_grocery()
            {
                Cust_details objCust1 = new Cust_details();
                objCust1.getName();
                Console.WriteLine($"xin chao {objCust1.strName}");
                Console.WriteLine("Ban co the mua cac hang tap hoa");
            }
        }
    }

    class Bakery_items
    {
        public void Ord_bakery()
        {
            Cust_details objCust2 = new Cust_details();
            objCust2.getName();
            Console.WriteLine($"xin chao {objCust2.strName}");
            Console.WriteLine("ban co the mua banh keo");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("ban muon mua gi \n1-hang tap hoa," +
                "\n2-banh keo\nhay chon:"
                );
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Grocery_items objGrocery = new Grocery_items();
                objGrocery.Ord_grocery();
            }
            else
            {
                if (choice == "2")
                {
                    Bakery_items objBakery = new Bakery_items();
                    objBakery.Ord_bakery();
                }
                else
                {
                    Console.WriteLine("chon 1 hoac 2");
                }
            }

            Console.ReadLine();
        }
    }
}