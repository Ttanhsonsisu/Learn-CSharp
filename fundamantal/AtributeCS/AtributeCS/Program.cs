using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AtributeCS
{
    internal class Program
    {
        // Type : include int , string , boolean , ...
        // GetProperties , GetFields, GetMethods
        // 
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] // (AttributeTargets)2 ~ AttributeTargets.class
         class Mota : Attribute
        {
            public string Name { get; set; }

            public string Description { get; set; }

            public Mota(string name, string description)
            {
                Name = name;
                Description = description;

            }
        }
        [Mota("ClassTest", "try Class")]
        class TestAttribute
        {
            public string Name { get; set; }

            [Mota("Function test", "try function")]
            public void Testc()
            {
                Console.WriteLine("test class attribute");
            }

            static void Main(string[] args)
            {

                TestAttribute testAtribute = new TestAttribute();
                testAtribute.GetType().GetMethods().ToList().ForEach( (MethodInfo x) => {
                    foreach (var item in x.GetCustomAttributes(false))
                    {
                        Mota moto = item as Mota;
                        if (moto != null)
                        {
                            Console.WriteLine(moto.Name +  " " +moto.Description);
                        }
                    }
                    });
                Type a;

                int number = 12;

                a = typeof(int); // lấy thông tin kiểu dữ liệu type

                Console.WriteLine(a);

                Type type = number.GetType(); // lấy thông tin của biến 

                Console.WriteLine(type.FullName);
                // array , properties 

                int[] testArray = { 1, 2, 3, 4 };

                Type t = testArray.GetType();

                t.GetProperties().ToList().ForEach(
                    (PropertyInfo e) =>
                    {
                        Console.WriteLine(e.Name);
                    }
                    );

                Console.WriteLine("--- fields");
                t.GetFields().ToList().ForEach(
                    (FieldInfo e) =>
                    {
                        Console.WriteLine(e.Name);
                    }
                    );


                Console.WriteLine("get methods");


                Console.ReadKey();
            }
        }
    }
}
