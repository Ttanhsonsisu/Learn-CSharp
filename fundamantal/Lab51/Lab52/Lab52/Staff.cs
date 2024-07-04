using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab52
{
    public class Staff : IPerson
    {
        public void Delete(object obj)
        {
            Console.WriteLine($"Da xoa doi tuong {obj}");
        }

        public void Display(object obj)
        {
            Console.WriteLine($"thong doi tuong {obj}");
        }

        public void Insert(object obj)
        {
            Console.WriteLine($"Da luu doi tuong {obj}");
        }

        public void UPdate(object obj)
        {
            Console.WriteLine($"Da cap nhat doi tuong {obj}");
        }
    }

    public class Student : IPerson
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void Delete(object obj)
        {
            Console.WriteLine($"Da xoa doi tuong {obj}");
        }

        public void Display(object obj)
        {
            Console.WriteLine($"thong doi tuong {obj}");
        }

        public void Insert(object obj)
        {
            Console.WriteLine($"Da luu doi tuong {obj}");
        }

        public void UPdate(object obj)
        {
            Console.WriteLine($"Da cap nhat doi tuong {obj}");
        }

        public void DisPlay(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine($"id {st.Id}");
            Console.WriteLine($"name {st.Name}");
            
        }
    }


}
