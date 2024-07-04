using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab102
{
    internal class Program
    {
        static void Main(string[] args)
        { string name = null;
            try
            {
                try
                {
                    Employee emp = new Employee("Van", "Ha noi", 17);
                
                } catch (Exception e) {

                    Console.WriteLine(e.Message);
                }
                //Console.WriteLine("do dai cua ten" + name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
