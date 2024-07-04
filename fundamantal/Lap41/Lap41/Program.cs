using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentAction action = new StudentAction();

            List<Student> listStudent = action.GetStudent();

            foreach (Student student in listStudent) {
                student.display();
            }

            Student st = action.GetStudent(2);

            st.display();

            List<Student> listAge = action.GetStudent(25, 30);

            foreach (Student student in listAge)
            {
                student.display();
            }

            Console.ReadLine();
        }
    }
}
